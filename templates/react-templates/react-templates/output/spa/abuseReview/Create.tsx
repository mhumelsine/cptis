import { useForm, isNotEmpty, hasLength, matches } from "@mantine/form";
import { Button, Group, Radio, TextInput, Grid, Checkbox } from "@mantine/core";
import { Accordion } from "@mantine/core";
import { DateInput } from "@mantine/dates";
import CodeSelect from "../controls/CodeSelect.tsx";
import { useApi } from "./types.ts";
import { notifications } from "@mantine/notifications";
import { useNavigate } from "react-router";

const Edit = () => {
  const api = useApi("AbuseReview.Create");

  const navigate = useNavigate();

  const form = useForm({
    mode: "uncontrolled",
    initialValues: {
      abuseReportNumber: "",
      ctpOffice: "",
      abuseReportCounty: "",
      hotlineReceivedDate: "",
      cptReceivedDate: "",
      cptReviewDate: "",
      medicalReviewDate: "",
      mandatoryReferralCriteria: "",
      medicalEvaluationRequired: "",
      districtAreaUnit: "",
      dcfNotifiedDate: "",
      nonCareTakerReport: "",
      referralDeclined: "",
      dateReferralDeclined: "",
      comments: "",
      confirm: "",
      preparedBy: "",
      preparedDate: "",
      cptOfficeMedicalPersonal: "",
    },
    validate: {
      abuseReportNumber: matches(
        /20\d{2}-\d+/,
        "Abuse report number must match the pattern 20\d{2}-\d+",
      ),
      abuseReportNumber: isNotEmpty("Abuse report number is required."),
      ctpOffice: isNotEmpty("Ctp office is required."),
      abuseReportCounty: isNotEmpty("Abuse report county is required."),
      hotlineReceivedDate: isNotEmpty("Hotline received date is required."),
      cptReceivedDate: isNotEmpty("Cpt received date is required."),
      cptReviewDate: isNotEmpty("Cpt review date is required."),
      medicalReviewDate: isNotEmpty("Medical review date is required."),

      districtAreaUnit: hasLength(
        { max: 30 },
        "District area unit can be no more than 30 characters long.",
      ),

      confirm: isNotEmpty("Confirm is required."),
      preparedBy: isNotEmpty("Prepared by is required."),
      preparedDate: isNotEmpty("Prepared date is required."),
    },
  });

  const handleSubmit = form.onSubmit((values) =>
    api
      .post(values)
      .then((created) => {
        notifications.show({
          title: "Saved!",
          message: "Abuse review created successfully!",
        });
        navigate(`/abuseReview/${created.id}`);
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
              <Grid.Col span={{ base: 2, md: 2, lg: 2 }}>
                <TextInput
                  label="Abuse report number"
                  placeholder="Abuse report number"
                  withAsterisk
                  key={form.key("abuseReportNumber")}
                  {...form.getInputProps("abuseReportNumber")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <CodeSelect
                  codeSet="cpt-offices"
                  label="Ctp office"
                  placeholder="Ctp office"
                  withAsterisk
                  key={form.key("ctpOffice")}
                  {...form.getInputProps("ctpOffice")}
                  searchable
                  clearable
                  allowDeselect
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <CodeSelect
                  codeSet="county"
                  label="Abuse report county"
                  placeholder="Abuse report county"
                  withAsterisk
                  key={form.key("abuseReportCounty")}
                  {...form.getInputProps("abuseReportCounty")}
                  searchable
                  clearable
                  allowDeselect
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Hotline received date"
                  placeholder="Hotline received date"
                  withAsterisk
                  key={form.key("hotlineReceivedDate")}
                  {...form.getInputProps("hotlineReceivedDate")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Cpt received date"
                  placeholder="Cpt received date"
                  withAsterisk
                  key={form.key("cptReceivedDate")}
                  {...form.getInputProps("cptReceivedDate")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Cpt review date"
                  placeholder="Cpt review date"
                  withAsterisk
                  key={form.key("cptReviewDate")}
                  {...form.getInputProps("cptReviewDate")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Medical review date"
                  placeholder="Medical review date"
                  withAsterisk
                  key={form.key("medicalReviewDate")}
                  {...form.getInputProps("medicalReviewDate")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <YesNo
                  label="Mandatory referral criteria"
                  placeholder="Mandatory referral criteria"
                  key={form.key("mandatoryReferralCriteria")}
                  {...form.getInputProps("mandatoryReferralCriteria")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <Radio
                  codeSet="medical-eval-required"
                  label="Medical evaluation required"
                  placeholder="Medical evaluation required"
                  key={form.key("medicalEvaluationRequired")}
                  {...form.getInputProps("medicalEvaluationRequired")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <TextInput
                  label="District area unit"
                  placeholder="District area unit"
                  key={form.key("districtAreaUnit")}
                  {...form.getInputProps("districtAreaUnit")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Dcf notified date"
                  placeholder="Dcf notified date"
                  key={form.key("dcfNotifiedDate")}
                  {...form.getInputProps("dcfNotifiedDate")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <YesNo
                  label="Non care taker report"
                  placeholder="Non care taker report"
                  key={form.key("nonCareTakerReport")}
                  {...form.getInputProps("nonCareTakerReport")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <CodeSelect
                  codeSet="county"
                  label="Referral declined"
                  placeholder="Referral declined"
                  key={form.key("referralDeclined")}
                  {...form.getInputProps("referralDeclined")}
                  searchable
                  clearable
                  allowDeselect
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Date referral declined"
                  placeholder="Date referral declined"
                  key={form.key("dateReferralDeclined")}
                  {...form.getInputProps("dateReferralDeclined")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <TextArea
                  label="Comments"
                  placeholder="Comments"
                  key={form.key("comments")}
                  {...form.getInputProps("comments")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <Check
                  label="Confirm"
                  placeholder="Confirm"
                  withAsterisk
                  key={form.key("confirm")}
                  {...form.getInputProps("confirm")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <TextInput
                  label="Prepared by"
                  placeholder="Prepared by"
                  withAsterisk
                  key={form.key("preparedBy")}
                  {...form.getInputProps("preparedBy")}
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <DateInput
                  label="Prepared date"
                  placeholder="Prepared date"
                  withAsterisk
                  key={form.key("preparedDate")}
                  {...form.getInputProps("preparedDate")}
                  clearable
                />
              </Grid.Col>
              <Grid.Col span={{ base: 12, md: 6, lg: 4 }}>
                <CodeSelect
                  codeSet="cpt-medical-personnel"
                  label="Cpt office medical personal"
                  placeholder="Cpt office medical personal"
                  key={form.key("cptOfficeMedicalPersonal")}
                  {...form.getInputProps("cptOfficeMedicalPersonal")}
                  searchable
                  clearable
                  allowDeselect
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
