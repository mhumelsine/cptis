import { fileURLToPath, URL } from 'node:url';
import { defineConfig } from 'vite';
import plugin from '@vitejs/plugin-react';
import fs from 'fs';
import path from 'path';
import child_process from 'child_process';
import { env } from 'process';

const isCI = env.CI === 'true'; 

// Only configure HTTPS locally
let httpsOptions = undefined;

if (!isCI) {
    const baseFolder =
        env.APPDATA !== undefined && env.APPDATA !== ''
            ? `${env.APPDATA}/ASP.NET/https`
            : `${env.HOME}/.aspnet/https`;

    const certificateName = "cptis.ui";
    const certFilePath = path.join(baseFolder, `${certificateName}.pem`);
    const keyFilePath = path.join(baseFolder, `${certificateName}.key`);

    try{
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

         httpsOptions = {
             key: fs.readFileSync(keyFilePath),
             cert: fs.readFileSync(certFilePath),
         };
         
        }catch(e){
            console.error(e);
        }
}

const target = env.ASPNETCORE_HTTPS_PORT
    ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}`
    : env.ASPNETCORE_URLS
    ? env.ASPNETCORE_URLS.split(';')[0]
    : 'https://localhost:7067';

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
                rewrite: (path) => path.replace(/^\/api/, '/api'),
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
        https: httpsOptions,
    },
});
