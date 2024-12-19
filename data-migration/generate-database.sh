#!/bin/bash

#exit if error occurs
set -e

NAME=$1
OUT_DIR=data-migration/build
SCRIPT_FILE_NAME="${OUT_DIR}/${NAME}.sql"
DBML_INPUT_FILE_NAME="${SCRIPT_FILE_NAME}_staging.dbml"
DBML_OUTPUT_FILE_NAME="$SCRIPT_FILE_NAME.dbml"
DATABASE_NAME="focus"
DATABASE_USER_ID="merlin-admin"
DATABASE_USER_PASSWORD="i-don't.care#1"
DATABASE_SERVER="merlindb.isf.com"
DATABASE_SERVER_PORT="5757"

rm -rf $OUT_DIR

#generate the migration
dotnet ef migrations add \
  --project src/Example.EntityFramework/Example.EntityFramework.csproj \
  --startup-project src/Example.Api/Example.Api.csproj \
  --context Example.EntityFramework.ExampleDbContext \
  --configuration Debug \
  --verbose "$NAME" \
  --output-dir Migrations

#generate the sql script from time zero to now
dotnet ef migrations script \
  --project src/Example.EntityFramework/Example.EntityFramework.csproj \
  --startup-project src/Example.Api/Example.Api.csproj \
  --context Example.EntityFramework.ExampleDbContext \
  --configuration Debug \
  --verbose 0 "$NAME" \
  --output "$SCRIPT_FILE_NAME" 
  
dotnet ef database update "$NAME" \
  --project src/Example.EntityFramework/Example.EntityFramework.csproj \
  --startup-project src/Example.Api/Example.Api.csproj \
  --context Example.EntityFramework.ExampleDbContext \
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

#execute the schema deployment
# -C -> trust client certificate without validation 
# -d -> Database name
# -E -> use a trusted connection (windows auth)
# -P -> password for sql auth
# -S -> Server to connect to
# -U -> Login/user ID
# -i -> input file
# -o -> outfile file
# -q -> inline query
#sqlcmd \
#  -C \
#  -d "$DATABASE_NAME" \
#  -U "$DATABASE_USER_ID"\
#  -P "$DATABASE_USER_PASSWORD" \
#  -S "${DATABASE_SERVER},${DATABASE_SERVER_PORT}" \
#  -i "$SCRIPT_FILE_NAME" \
#  -o "${SCRIPT_FILE_NAME}_${DATABASE_SERVER}_result.txt"

#use dlt to load the original source tables into a staging schema

#use sqlmesh or dbt to transform the data into the new table structure

