import React, { useState } from "react";
import { Button, Checkbox, Option } from "@fluentui/react-components";
import CustomDropdown from "../../common/controls/inputs/CustomDropdown";
import { Stack } from "@fluentui/react";
import CustomInput from "../../common/controls/inputs/CustomInput";
import useApi from "../../api/hooks/useApi";
import CustomCheckbox from "../../common/controls/inputs/CustomCheckbox";

interface FormData {
  name?: string;
  email?: string;
  termsAccepted?: boolean;
  selectedOption?: string;
}

interface StatelessFormProps {
  initialData?: FormData;
}

const StatelessForm: React.FC<StatelessFormProps> = () => {
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
      <Stack tokens={{ childrenGap: 10 }}>
        <CustomInput
          id="name"
          type="text"
          label="Name"
          name="name"
          defaultValue={data?.name || ""}
          validationMessage={errors?.Name}
        />

        <CustomInput
          id="email"
          label="Email"
          name="email"
          type="email"
          defaultValue={data?.email || ""}
          required
          validationMessage={errors?.Email}
        />

        <CustomCheckbox
          id="termsAccepted"
          label="Accept Terms and Conditions"
          name="termsAccepted"
          defaultChecked={data?.TermsAccepted || false}
          validationMessage={errors?.TermsAccepted}
          required
        />

        <CustomDropdown
          id="selectedOption"
          label="Choose an Option"
          name="selectedOption"
          required
          defaultValue={data?.selectedOption || ""}
          options={["option1", "option2", "option3"]}
          validationMessage={errors?.SelectedOption}
        />

        <Button type="submit">Submit</Button>
      </Stack>
    </form>
  );
};

export default StatelessForm;
