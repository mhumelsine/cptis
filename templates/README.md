# Get Running

## Pre-reqs
- [Entity Framework Tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

## Generating Database and DBML
- This will not work while pointing at SQLite.  SQLite is not supported by dbml.  To generate, you will need to go to:
  - Go to `src/Cptis.Api/Database.cs` and swap the SQLServer and SQLite calls.
  - Ensure there is a valid connection string configured in `appsettings.Development.json`
- From the project root, run `sh data-migration/generate-database.sh {M.m.p}` example `sh generate-database.sh 1.0.0` for the first version.
  - The artifacts will be generated in `data-migration/build`.
  - The migration will be applied the database, sql script generated, and dbml generated.
- To remove, run `sh data-migration/rollback_migration.sh`.
  - The EF migration will be removed and the tables in the database will be dropped.


