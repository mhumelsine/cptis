import { useForm, isNotEmpty, isEmail, isInRange, hasLength, matches } from '@mantine/form';
import { Button, Group, TextInput, NumberInput } from '@mantine/core';

const Edit = () => {
  const form = useForm({
    mode: 'uncontrolled',
    initialValues: {
        name: '',
        description: '',
    },
    validate: {
        name: [hasLength({ min: 2, max: 50 }, 'Name must be 2-50 characters long.'),isNotEmpty('Name is required.'),],
        description: [isNotEmpty('Description is required.'),hasLength({ max: 255 }, 'Description can be no more than 255 characters long.'),],
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
        label="Description"
        placeholder="Description"
        withAsterisk
        key={form.key("description")}
        {...form.getInputProps("description")}
    />
    <Group justify="flex-end" mt="md">
        <Button type="submit">Save</Button>
    </Group>
  </form>;
}

export default Edit;