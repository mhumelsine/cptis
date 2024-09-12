import * as React from 'react'
import { createRoot } from 'react-dom/client'
import './index.css' 
import CptisHomePage from './CptisHomePage';
import { QueryClient, QueryClientProvider } from '@tanstack/react-query';
 

const queryClient = new QueryClient();

createRoot(document.getElementById('root')!).render(
    <React.StrictMode>
        <QueryClientProvider client={queryClient}>
           <CptisHomePage />
        </QueryClientProvider>
    </React.StrictMode>
);


