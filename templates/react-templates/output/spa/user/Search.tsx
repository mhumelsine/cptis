import { useForm, isNotEmpty, isEmail, isInRange, hasLength, matches } from '@mantine/form';
import { Button, Group, TextInput, NumberInput } from '@mantine/core';

const Edit = () => {
  const form = useForm({
    mode: 'uncontrolled',
    initialValues: {
        name: '',
        job: '',
        email: '',
        favoriteColor: '',
        age: 18,
    },
    validate: {
        name: [hasLength({ min: 2, max: 10 }, 'Name must be 2-10 characters long.'),isNotEmpty('Name is required.'),],
        job: [isNotEmpty('Job is required.'),],
        email: [isNotEmpty('Email is required.'),],
        favoriteColor: [matches(/^#([0-9a-f]{3}){1,2}$/, 'Favorite color must match the pattern ^#([0-9a-f]{3}){1,2}$'),isNotEmpty('Favorite color is required.'),],
        age: [isInRange({ min: 18, max: 120 }, 'Age must be between 18-120.'),],
    }
  });

  return <form onSubmit={form.onSubmit(() => {})}>
    <TextInput
        label="Name"
        placeholder="Name"
        withAsterisk
        key={form.key("name")}
        {...form.getInputProps("name")}
    />
    <TextInput
        label="Job"
        placeholder="Job"
        withAsterisk
        key={form.key("job")}
        {...form.getInputProps("job")}
    />
    <TextInput
        label="Email"
        placeholder="Email"
        withAsterisk
        key={form.key("email")}
        {...form.getInputProps("email")}
    />
    <TextInput
        label="Favorite color"
        placeholder="Favorite color"
        withAsterisk
        key={form.key("favoriteColor")}
        {...form.getInputProps("favoriteColor")}
    />
    <NumberInput
        label="Age"
        placeholder="Age"
        key={form.key("age")}
        {...form.getInputProps("age")}
    />
    <Group justify="flex-end" mt="md">
        <Button type="submit">Save</Button>
    </Group>
  </form>;
}

export default Edit;