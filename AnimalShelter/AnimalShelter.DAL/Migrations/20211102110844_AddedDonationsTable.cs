using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.DAL.Migrations
{
    public partial class AddedDonationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdoptionPapers_Visitors_VisiterID",
                table: "AdoptionPapers");

            migrationBuilder.DropIndex(
                name: "IX_AdoptionPapers_VisiterID",
                table: "AdoptionPapers");

            migrationBuilder.RenameColumn(
                name: "VisiterID",
                table: "Visitors",
                newName: "VisitorID");

            migrationBuilder.AddColumn<int>(
                name: "VisitorID",
                table: "AdoptionPapers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    DonationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sum = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.DonationID);
                    table.ForeignKey(
                        name: "FK_Donations_Visitors_VisitorID",
                        column: x => x.VisitorID,
                        principalTable: "Visitors",
                        principalColumn: "VisitorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionPapers_VisitorID",
                table: "AdoptionPapers",
                column: "VisitorID");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_VisitorID",
                table: "Donations",
                column: "VisitorID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdoptionPapers_Visitors_VisitorID",
                table: "AdoptionPapers",
                column: "VisitorID",
                principalTable: "Visitors",
                principalColumn: "VisitorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdoptionPapers_Visitors_VisitorID",
                table: "AdoptionPapers");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_AdoptionPapers_VisitorID",
                table: "AdoptionPapers");

            migrationBuilder.DropColumn(
                name: "VisitorID",
                table: "AdoptionPapers");

            migrationBuilder.RenameColumn(
                name: "VisitorID",
                table: "Visitors",
                newName: "VisiterID");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionPapers_VisiterID",
                table: "AdoptionPapers",
                column: "VisiterID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdoptionPapers_Visitors_VisiterID",
                table: "AdoptionPapers",
                column: "VisiterID",
                principalTable: "Visitors",
                principalColumn: "VisiterID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
