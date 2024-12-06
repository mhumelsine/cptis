using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cptis.infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitializeCPTIS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientDemographic",
                columns: table => new
                {
                    ClientDemographicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MiddleInitial = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Suffix = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Race = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Ethnicity = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ver = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FamilyId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DeathDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    County = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Medicaid = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    MedicaidId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HmoStatus = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ThirdParty = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ThirdPartyId = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    PrimaryCarePhys = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    MediPass = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    UserFirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastNameAka = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FirstNameAka = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MidInitAka = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Disability = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    SatpRace = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    OtherSex = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OtherRace = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AddressOther = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CityOther = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: false),
                    StateOther = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ZipOther = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    CountryOther = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CountyOther = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LicenseProfessional = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    LicenseType = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LicenseType2 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LicenseType3 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDemographic", x => x.ClientDemographicId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientDemographic");
        }
    }
}
