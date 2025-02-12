import { useForm, isNotEmpty, isEmail, isInRange, hasLength, matches } from '@mantine/form';
import { Button, Group, TextInput, NumberInput } from '@mantine/core';

const Edit = () => {
  const form = useForm({
    mode: 'uncontrolled',
    initialValues: {
        code: '',
        description: '',
    },
    validate: {
        code: [hasLength({ min: 2, max: 25 }, 'Code must be 2-25 characters long.'),],
        description: [isNotEmpty('Description is required.'),hasLength({ max: 255 }, 'Description can be no more than 255 characters long.'),],
    }
  });

  return <form onSubmit={form.onSubmit(() => {})}>
    <TextInput
        label="Code"
        placeholder="Code"
        key={form.key("code")}
        {...form.getInputProps("code")}
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