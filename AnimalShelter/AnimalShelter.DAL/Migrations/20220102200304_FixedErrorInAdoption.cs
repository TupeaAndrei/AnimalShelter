using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.DAL.Migrations
{
    public partial class FixedErrorInAdoption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdoptionPapers_Animals_AnimalID",
                table: "AdoptionPapers");

            migrationBuilder.DropIndex(
                name: "IX_AdoptionPapers_AnimalID",
                table: "AdoptionPapers");

            migrationBuilder.DropColumn(
                name: "AnimalID",
                table: "AdoptionPapers");

            migrationBuilder.AddColumn<string>(
                name: "AnimalName",
                table: "AdoptionPapers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MedicalJournals",
                keyColumn: "JournalID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 2, 22, 3, 4, 499, DateTimeKind.Local).AddTicks(6645));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnimalName",
                table: "AdoptionPapers");

            migrationBuilder.AddColumn<int>(
                name: "AnimalID",
                table: "AdoptionPapers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MedicalJournals",
                keyColumn: "JournalID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 2, 21, 50, 9, 170, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionPapers_AnimalID",
                table: "AdoptionPapers",
                column: "AnimalID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdoptionPapers_Animals_AnimalID",
                table: "AdoptionPapers",
                column: "AnimalID",
                principalTable: "Animals",
                principalColumn: "AnimalID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
