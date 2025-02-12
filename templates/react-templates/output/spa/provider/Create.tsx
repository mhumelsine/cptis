import { useForm, isNotEmpty, isEmail, isInRange, hasLength, matches } from '@mantine/form';
import { Button, Group, TextInput, NumberInput } from '@mantine/core';

const Edit = () => {
  const form = useForm({
    mode: 'uncontrolled',
    initialValues: {
        providerID: '',
        lastName: '',
        firstName: '',
        title: '',
        securityID: '',
        terminationDate: '',
        approvedStatuteStaff: '',
        cmsApprovalDate: '',
        license: '',
        licenseExpirationDate: '',
        basicForensicInterviewTrainingCompletionDate: '',
        advancedForensicInterviewTrainingCompletionDate: '',
    },
    validate: {
        providerID: [hasLength({ min: 2, max: 20 }, 'Providerid must be 2-20 characters long.'),isNotEmpty('Providerid is required.'),],
        lastName: [hasLength({ min: 2, max: 50 }, 'Last name must be 2-50 characters long.'),],
        firstName: [hasLength({ min: 2, max: 50 }, 'First name must be 2-50 characters long.'),],
        title: [hasLength({ min: 2, max: 50 }, 'Title must be 2-50 characters long.'),],
        securityID: [hasLength({ min: 2, max: 50 }, 'Securityid must be 2-50 characters long.'),],
        terminationDate: [],
        approvedStatuteStaff: [],
        cmsApprovalDate: [],
        license: [],
        licenseExpirationDate: [],
        basicForensicInterviewTrainingCompletionDate: [],
        advancedForensicInterviewTrainingCompletionDate: [],
    }
  });

  return <form onSubmit={form.onSubmit(() => {})}>
    <TextInput
        label="Providerid"
        placeholder="Providerid"
        withAsterisk
        key={form.key("providerID")}
        {...form.getInputProps("providerID")}
    />
    <TextInput
        label="Last name"
        placeholder="Last name"
        key={form.key("lastName")}
        {...form.getInputProps("lastName")}
    />
    <TextInput
        label="First name"
        placeholder="First name"
        key={form.key("firstName")}
        {...form.getInputProps("firstName")}
    />
    <TextInput
        label="Title"
        placeholder="Title"
        key={form.key("title")}
        {...form.getInputProps("title")}
    />
    <TextInput
        label="Securityid"
        placeholder="Securityid"
        key={form.key("securityID")}
        {...form.getInputProps("securityID")}
    />
    <DateInput
        label="Termination date"
        placeholder="Termination date"
        key={form.key("terminationDate")}
        {...form.getInputProps("terminationDate")}
        clearable
    />
    <CodeSelect
        codeSet='statuteStaff'
        label="Approved statute staff"
        placeholder="Approved statute staff"
        key={form.key("approvedStatuteStaff")}
        {...form.getInputProps("approvedStatuteStaff")}
        searchable
        clearable
        allowDeselect
    />
    <DateInput
        label="Cms approval date"
        placeholder="Cms approval date"
        key={form.key("cmsApprovalDate")}
        {...form.getInputProps("cmsApprovalDate")}
        clearable
    />
    <TextInput
        label="License"
        placeholder="License"
        key={form.key("license")}
        {...form.getInputProps("license")}
    />
    <DateInput
        label="License expiration date"
        placeholder="License expiration date"
        key={form.key("licenseExpirationDate")}
        {...form.getInputProps("licenseExpirationDate")}
        clearable
    />
    <DateInput
        label="Basic forensic interview training completion date"
        placeholder="Basic forensic interview training completion date"
        key={form.key("basicForensicInterviewTrainingCompletionDate")}
        {...form.getInputProps("basicForensicInterviewTrainingCompletionDate")}
        clearable
    />
    <DateInput
        label="Advanced forensic interview training completion date"
        placeholder="Advanced forensic interview training completion date"
        key={form.key("advancedForensicInterviewTrainingCompletionDate")}
        {...form.getInputProps("advancedForensicInterviewTrainingCompletionDate")}
        clearable
    />
    <Group justify="flex-end" mt="md">
        <Button type="submit">Save</Button>
    </Group>
  </form>;
}

export default Edit;