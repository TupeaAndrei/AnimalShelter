using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.DAL.Migrations
{
    public partial class HostingFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hosting",
                table: "AdoptionPapers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MedicalJournals",
                keyColumn: "JournalID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 3, 10, 53, 44, 703, DateTimeKind.Local).AddTicks(2346));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hosting",
                table: "AdoptionPapers");

            migrationBuilder.UpdateData(
                table: "MedicalJournals",
                keyColumn: "JournalID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 2, 22, 3, 4, 499, DateTimeKind.Local).AddTicks(6645));
        }
    }
}
