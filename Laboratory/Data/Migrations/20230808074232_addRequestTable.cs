using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratory.Data.Migrations
{
    public partial class addRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalOrResidenceId = table.Column<int>(type: "int", nullable: false),
                    UniversityNumber = table.Column<int>(type: "int", nullable: false),
                    StudentsStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstNameEnglish = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FatherNameEnglish = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GrandFatherNameEnglish = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FamilyNameEnglish = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FirstNameArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherNameArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrandFatherNameArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyNameArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalFileNo = table.Column<int>(type: "int", nullable: true),
                    TestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NationalOrResidenceIdFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CopyOfStudentId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Request");
        }
    }
}
