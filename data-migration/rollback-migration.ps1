$EF_PROJECT_FILE="src/Cptis.EntityFramework/Cptis.EntityFramework.csproj"
$STARTUP_PROJECT_FILE="src/Cptis.Api/Cptis.Api.csproj"
$EF_CONTEXT="Cptis.EntityFramework.CptisWriteContext"

#remove the migration
dotnet ef migrations remove `
  --project "$EF_PROJECT_FILE" `
  --startup-project "$STARTUP_PROJECT_FILE" `
  --context "$EF_CONTEXT" `
  --configuration Debug `
  --verbose `
  --force