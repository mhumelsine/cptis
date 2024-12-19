#!/bin/bash

#exit if error occurs
set -e

NAME="${1-1.0.0}"
OUT_DIR=data-migration/build
SCRIPT_FILE_NAME="${OUT_DIR}/${NAME}.sql"
DBML_INPUT_FILE_NAME="${SCRIPT_FILE_NAME}_staging.dbml"
DBML_OUTPUT_FILE_NAME="$SCRIPT_FILE_NAME.dbml"
EF_PROJECT_FILE="src/Cptis.EntityFramework/Cptis.EntityFramework.csproj"
STARTUP_PROJECT_FILE="src/Cptis.Api/Cptis.Api.csproj"
EF_CONTEXT="Cptis.EntityFramework.CptisWriteContext"

rm -rf $OUT_DIR

#generate the migration
dotnet ef migrations add \
  --project "$EF_PROJECT_FILE" \
  --startup-project "$STARTUP_PROJECT_FILE" \
  --context "$EF_CONTEXT" \
  --configuration Debug \
  --verbose "$NAME" \
  --output-dir Migrations

#generate the sql script from time zero to now
dotnet ef migrations script \
  --project "$EF_PROJECT_FILE" \
  --startup-project "$STARTUP_PROJECT_FILE" \
  --context "$EF_CONTEXT" \
  --configuration Debug \
  --verbose 0 "$NAME" \
  --output "$SCRIPT_FILE_NAME" 
  
dotnet ef database update "$NAME" \
  --project "$EF_PROJECT_FILE" \
  --startup-project "$STARTUP_PROJECT_FILE" \
  --context "$EF_CONTEXT" \
  --configuration Debug \
  --no-build
  
#only take the content between the BEGIN TRANSACTION and INSERT
awk '
/BEGIN TRANSACTION;/ {on=1}
/INSERT INTO \[__MIGRATIONS\]/ {on=0}
{ if (on) print $0;}
' < "$SCRIPT_FILE_NAME" | tail -n +2 > "$DBML_INPUT_FILE_NAME" 


#generate the dbml
sql2dbml "$DBML_INPUT_FILE_NAME" --mssql -o "$DBML_OUTPUT_FILE_NAME"

#remove file after dbml is generated
rm "$DBML_INPUT_FILE_NAME"

#use dlt to load the original source tables into a staging schema

#use sqlmesh or dbt to transform the data into the new table structure

