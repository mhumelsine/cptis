import { useEndpoint } from '../../hooks';

export interface Provider {
    id: string;
    providerID: string;
    lastName: string;
    firstName: string;
    title: string;
    securityID: string;
    terminationDate: string;
    approvedStatuteStaff: string;
    cmsApprovalDate: string;
    license: string;
    licenseExpirationDate: string;
    basicForensicInterviewTrainingCompletionDate: string;
    advancedForensicInterviewTrainingCompletionDate: string;
}

export interface ProviderList {
    providerID: string;
    lastName: string;
    firstName: string;
    title: string;
    securityID: string;
}

export const useApi = (traceLocation: string) =>
    useEndpoint<Provider, ProviderList, Provider>('provider', {
        version: '1.0',
        traceLocation
    });