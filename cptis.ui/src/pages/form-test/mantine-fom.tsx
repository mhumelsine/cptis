import React, { useState } from "react";
import { TextInput, Checkbox, Select, Button, Stack } from "@mantine/core";
import useApi from "../../api/hooks/useApi";

interface FormData {
  name?: string;
  email?: string;
  termsAccepted?: boolean;
  selectedOption?: string;
}

interface StatelessFormProps {
  initialData?: FormData;
}

const MantineFormStateless: React.FC<StatelessFormProps> = () => {
  const [errors, setErrors] = useState<any>({});
  const api = useApi();
  const { data, isFetched } = api.GET<any>("api/TestForm", "/test");

  const { mutate } = api.POST<FormData>(
    "api/TestForm/test",
    {
      onSuccess: (data) => {
        console.log("Form submitted successfully:", data);
      },
      onError: (error) => {
        console.error("Error submitting form:", error);
        setErrors(JSON.parse(error.message));
      },
    },
    "multipart/form-data"
  );

  const handleSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    const formData = new FormData(e.currentTarget);

    mutate({ params: "", body: formData });
  };

  if (!isFetched) return <div>Loading...</div>;

  return (
    <form onSubmit={handleSubmit}>
      <Stack gap={16}>
        <TextInput
          label="Name"
          name="name"
          defaultValue={data?.name || ""}
          required
          placeholder="Enter your name"
          error={errors?.Name}
        />

        <TextInput
          label="Email"
          name="email"
          type="email"
          defaultValue={data?.email || ""}
          placeholder="Enter your email"
          error={errors?.Email}
        />

        <Checkbox
          label="Accept Terms and Conditions"
          name="termsAccepted"
          defaultChecked={data?.termsAccepted || false}
          error={errors?.TermsAccepted}
        />

        <Select
          label="Choose an Option"
          name="selectedOption"
          data={[
            { value: "option1", label: "Option 1" },
            { value: "option2", label: "Option 2" },
            { value: "option3", label: "Option 3" },
          ]}
          placeholder="Select an option"
          defaultValue={data?.selectedOption || null}
          required
          error={errors?.SelectedOption}
        />

        <Button type="submit">Submit</Button>
      </Stack>
    </form>
  );
};

export default MantineFormStateless;
