import { useForm, isNotEmpty, hasLength, matches } from "@mantine/form";
import { Button, Group, Radio, TextInput, Grid, Checkbox } from "@mantine/core";
import { Accordion } from "@mantine/core";
import { DateInput } from "@mantine/dates";
import CodeSelect from "../controls/CodeSelect.tsx";
import { useApi } from "./types.ts";
import { notifications } from "@mantine/notifications";
import { useNavigate } from "react-router";

const Edit = () => {
  const api = useApi("Provider.Create");

  const navigate = useNavigate();

  const form = useForm({
    mode: "uncontrolled",
    initialValues: {
      providerID: "",
      lastName: "",
      firstName: "",
      title: "",
      securityID: "",
      terminationDate: "",
      approvedStatuteStaff: "",
      cmsApprovalDate: "",
      license: "",
      licenseExpirationDate: "",
      basicForensicInterviewTrainingCompletionDate: "",
      advancedForensicInterviewTrainingCompletionDate: "",
    },
    validate: {
      providerID: hasLength(
        { min: 2, max: 20 },
        "Providerid must be 2-20 characters long.",
      ),
      providerID: isNotEmpty("Providerid is required."),
      lastName: hasLength(
        { min: 2, max: 50 },
        "Last name must be 2-50 characters long.",
      ),
      firstName: hasLength(
        { min: 2, max: 50 },
        "First name must be 2-50 characters long.",
      ),
      title: hasLength(
        { min: 2, max: 50 },
        "Title must be 2-50 characters long.",
      ),
      securityID: hasLength(
        { min: 2, max: 50 },
        "Securityid must be 2-50 characters long.",
      ),

      license: hasLength(
        { max: 100 },
        "License can be no more than 100 characters long.",
      ),
    },
  });

  const handleSubmit = form.onSubmit((values) =>
    api
      .post(values)
      .then((created) => {
        notifications.show({
          title: "Saved!",
          message: "Provider created successfully!",
        });
        navigate(`/provider/${created.id}`);
      })
      .catch((error) => {
        console.table(error);
        notifications.show({
          title: "Error",
          message:
            "TODO" +
            Object.entries(error)
              .map((k, v) => `${k}; ${v}`)
              .join("; "),
        });
      }),
  );

  return (
    <form onSubmit={handleSubmit}>
      <Accordion defaultValue="generalInformation">
        <Accordion.Item key="generalInformation" value="generalInformation">
          <Accordion.Control>General Information</Accordion.Control>
          <Accordion.Panel>
            <Grid>
              <Grid.Col span={{ base: 12, md: 12, lg: 12 }}>
                <TextInput
                  label="Providerid"
                  placeholder="Providerid"
                  withAsterisk
                  key={form.key("providerID")}
                  {...form.getInputProps("providerID")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <TextInput
                  label="Last name"
                  placeholder="Last name"
                  key={form.key("lastName")}
                  {...form.getInputProps("lastName")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <TextInput
                  label="First name"
                  placeholder="First name"
                  key={form.key("firstName")}
                  {...form.getInputProps("firstName")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <TextInput
                  label="Title"
                  placeholder="Title"
                  key={form.key("title")}
                  {...form.getInputProps("title")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <TextInput
                  label="Securityid"
                  placeholder="Securityid"
                  key={form.key("securityID")}
                  {...form.getInputProps("securityID")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Termination date"
                  placeholder="Termination date"
                  key={form.key("terminationDate")}
                  {...form.getInputProps("terminationDate")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <CodeSelect
                  codeSet="statuteStaff"
                  label="Approved statute staff"
                  placeholder="Approved statute staff"
                  key={form.key("approvedStatuteStaff")}
                  {...form.getInputProps("approvedStatuteStaff")}
                  searchable
                  clearable
                  allowDeselect
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Cms approval date"
                  placeholder="Cms approval date"
                  key={form.key("cmsApprovalDate")}
                  {...form.getInputProps("cmsApprovalDate")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <TextInput
                  label="License"
                  placeholder="License"
                  key={form.key("license")}
                  {...form.getInputProps("license")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="License expiration date"
                  placeholder="License expiration date"
                  key={form.key("licenseExpirationDate")}
                  {...form.getInputProps("licenseExpirationDate")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Basic forensic interview training completion date"
                  placeholder="Basic forensic interview training completion date"
                  key={form.key("basicForensicInterviewTrainingCompletionDate")}
                  {...form.getInputProps(
                    "basicForensicInterviewTrainingCompletionDate",
                  )}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Advanced forensic interview training completion date"
                  placeholder="Advanced forensic interview training completion date"
                  key={form.key(
                    "advancedForensicInterviewTrainingCompletionDate",
                  )}
                  {...form.getInputProps(
                    "advancedForensicInterviewTrainingCompletionDate",
                  )}
                  clearable
                />
              </Grid.Col>
            </Grid>
          </Accordion.Panel>
        </Accordion.Item>
      </Accordion>
      <Group justify="flex-end" mt="md">
        <Button type="submit">Save</Button>
      </Group>
    </form>
  );
};

export default Edit;
