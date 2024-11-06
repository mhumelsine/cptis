To create a New table and/or update the Database you need to:

1. Create/Update the entity in the cptis.domain project in their own folder.
2. Create/Update the Configuration class in the cptis.infrastructure project in their own folder.				
3. Create a Migration by running the command `dotnet ef migrations add <MigrationName>` in the cptis.infrastructure project.
4. Commit Changes adding the Task number for tracking purposes.