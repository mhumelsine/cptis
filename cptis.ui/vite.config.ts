import { fileURLToPath, URL } from 'node:url';
import { defineConfig } from 'vite';
import plugin from '@vitejs/plugin-react';
import fs from 'fs';
import path from 'path';
import child_process from 'child_process';
import { env } from 'process';

const isCI = env.CI === 'true'; // Detect if running in a CI/CD pipeline
const baseFolder =
    env.APPDATA !== undefined && env.APPDATA !== ''
        ? `${env.APPDATA}/ASP.NET/https`
        : `${env.HOME}/.aspnet/https`;

const certificateName = "cptis.ui";
const certFilePath = path.join(baseFolder, `${certificateName}.pem`);
const keyFilePath = path.join(baseFolder, `${certificateName}.key`);

if (!isCI) {
    // Only attempt to create or load certificates outside of CI/CD
    if (!fs.existsSync(certFilePath) || !fs.existsSync(keyFilePath)) {
        if (
            child_process.spawnSync(
                'dotnet',
                [
                    'dev-certs',
                    'https',
                    '--export-path',
                    certFilePath,
                    '--format',
                    'Pem',
                    '--no-password',
                ],
                { stdio: 'inherit' }
            ).status !== 0
        ) {
            throw new Error('Could not create certificate.');
        }
    }
}

const target = env.ASPNETCORE_HTTPS_PORT
    ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}`
    : env.ASPNETCORE_URLS
    ? env.ASPNETCORE_URLS.split(';')[0]
    : 'https://localhost:7067';
console.log('target: ====>', target);

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [plugin()],
    resolve: {
        alias: {
            '@': fileURLToPath(new URL('./src', import.meta.url)),
        },
    },
    server: {
        proxy: {
            '/api': {
                target,
                changeOrigin: true,
                rewrite: (path) => {
                    console.log('Proxying path:', path);
                    return path.replace(/^\/api/, '/api');
                },
                secure: false,
            },
            '/account': {
                target,
                changeOrigin: true,
                rewrite: (path) => path.replace(/^\/account/, '/account'),
                secure: false,
            },
        },
        port: 5173,
        https: !isCI // Disable HTTPS for CI/CD
            ? {
                  key: fs.readFileSync(keyFilePath),
                  cert: fs.readFileSync(certFilePath),
              }
            : undefined,
    },
});
