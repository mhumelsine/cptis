param(
    [string] $NAME
)

#exit if error occurs
$ErrorActionPreference = [System.Management.Automation.ActionPreference]::Stop

if(!$NAME) {
    $NAME = "1.0.0";
}

Write-Host "Migration Name: '$NAME'"

$OUT_DIR="data-migration/build"
$SCRIPT_FILE_NAME="$OUT_DIR/$NAME.sql"
$DBML_INPUT_FILE_NAME="$($SCRIPT_FILE_NAME)_staging.dbml"
$DBML_OUTPUT_FILE_NAME="$($SCRIPT_FILE_NAME).dbml"
$EF_PROJECT_FILE="src/Cptis.EntityFramework/Cptis.EntityFramework.csproj"
$STARTUP_PROJECT_FILE="src/Cptis.Api/Cptis.Api.csproj"
$EF_CONTEXT="Cptis.EntityFramework.CptisWriteContext"

if(Test-Path $OUT_DIR) {
    Remove-Item -Recurse -Force "$OUT_DIR"
}

#generate the migration
dotnet ef migrations add `
  --project "$EF_PROJECT_FILE" `
  --startup-project "$STARTUP_PROJECT_FILE" `
  --context "$EF_CONTEXT" `
  --configuration Debug `
  --verbose "$NAME" `
  --output-dir Migrations

#generate the sql script from time zero to now
dotnet ef migrations script `
  --project "$EF_PROJECT_FILE" `
  --startup-project "$STARTUP_PROJECT_FILE" `
  --context "$EF_CONTEXT" `
  --configuration Debug `
  --verbose 0 "$NAME" `
  --output "$SCRIPT_FILE_NAME" 

#  Uncomment when you want the model applied to the database as part of this script
#if [ "$APPLY_TO_DB" -eq 0 ]; then
#  dotnet ef database update "$NAME" `
#    --project "$EF_PROJECT_FILE" `
#    --startup-project "$STARTUP_PROJECT_FILE" `
#    --context "$EF_CONTEXT" `
#    --configuration Debug `
#    --no-build
#fi
  
#only take the content between the BEGIN TRANSACTION and INSERT
$start=$false;
gc $SCRIPT_FILE_NAME | Foreach-Object {
    if ($_ -eq "BEGIN TRANSACTION;") { $start=$true }
    if ($_ -match "^INSERT INTO \[__MIGRATIONS\].*") { break;  }
    
    if($start -eq $true)  { $_ >> $DBML_INPUT_FILE_NAME }
}

#generate the dbml
sql2dbml "$DBML_INPUT_FILE_NAME" --mssql -o "$DBML_OUTPUT_FILE_NAME"

#remove file after dbml is generated
#rm "$DBML_INPUT_FILE_NAME"

#use dlt to load the original source tables into a staging schema

#use sqlmesh or dbt to transform the data into the new table structure

