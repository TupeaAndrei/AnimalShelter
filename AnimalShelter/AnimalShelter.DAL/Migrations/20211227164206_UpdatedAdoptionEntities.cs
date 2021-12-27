using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.DAL.Migrations
{
    public partial class UpdatedAdoptionEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdoptionReason",
                table: "AdoptionPapers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adresss",
                table: "AdoptionPapers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Allergy",
                table: "AdoptionPapers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseType",
                table: "AdoptionPapers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PetCount",
                table: "AdoptionPapers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "AdoptionPapers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Preparations",
                table: "AdoptionPapers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Town",
                table: "AdoptionPapers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "AdoptionReason",
                table: "AdoptionPapers");

            migrationBuilder.DropColumn(
                name: "Adresss",
                table: "AdoptionPapers");

            migrationBuilder.DropColumn(
                name: "Allergy",
                table: "AdoptionPapers");

            migrationBuilder.DropColumn(
                name: "HouseType",
                table: "AdoptionPapers");

            migrationBuilder.DropColumn(
                name: "PetCount",
                table: "AdoptionPapers");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "AdoptionPapers");

            migrationBuilder.DropColumn(
                name: "Preparations",
                table: "AdoptionPapers");

            migrationBuilder.DropColumn(
                name: "Town",
                table: "AdoptionPapers");
        }
    }
}
