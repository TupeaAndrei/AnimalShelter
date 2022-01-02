using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalID", "Age", "Name", "OptionalDetails", "Race", "RegistrationDate", "Type" },
                values: new object[,]
                {
                    { 1, 3, "Alfie", "Good with everyone", "German Shepherd", new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "House dog" },
                    { 19, 2, "Sammy & Ivi", "Don't want to be separated, very scared much love needed", "Unknown", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House cats" },
                    { 18, 4, "Blanca & Blanco", "Scared of dogs, Din't want to be separated", "American Curl", new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House cats" },
                    { 17, 4, "Oreo", "Good with everyone, but a little scared", "Unknown", new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garden cat" },
                    { 16, 3, "Misty", "Bad wiith other animals", "Bobtail des Kouriles", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "House cat" },
                    { 15, 1, "Loki", "Good with everyone but shy, The youngest pet in the shelter", "Siberien", new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "House cat" },
                    { 14, 2, "Milo", "Good with everyone", "Unknown", new DateTime(2019, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garden cat" },
                    { 13, 6, "Maya", "Good with other animals", "American Curl", new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "House cat" },
                    { 12, 3, "Koko", "Good with everyone", "Unknown", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House dog" },
                    { 20, 4, "Cara", "Good with everyone", "Bengal", new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garden cat" },
                    { 11, 2, "Kira", "Good with everyone", "Brittany", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House dog" },
                    { 9, 2, "Lucky", "Shy a little scared by other dogs", "Unknown", new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "House dog" },
                    { 8, 2, "Bailey", "Good with other dogs", "Unknown", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House dog" },
                    { 7, 6, "Benji", "Doesn't like cats", "Boxer", new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guard Dog" },
                    { 6, 2, "Bella", "Good with everyone", "Unknown", new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "House dog" },
                    { 5, 10, "Sparky", "Good with everyone, oldest dog", "unknown", new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guard dog" },
                    { 4, 1, "Brownie", "Good with everyone", "Bloodhound", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House dog" },
                    { 3, 1, "Bruno", "Good with everyone", "Unknown", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "House dog" },
                    { 2, 2, "Darla", "Good with everyone", "Belgian Malinois", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guard Dog" },
                    { 10, 3, "Max", "Good with people, bad with other animals", "Rhodesian Ridgeback", new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guard Dog" },
                    { 21, 1, "Nala", "Good with everyone, very playful", "Unknown", new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "house cat" }
                });

            migrationBuilder.InsertData(
                table: "Cages",
                columns: new[] { "CageID", "AnimalID", "Dimension", "Label" },
                values: new object[,]
                {
                    { 1, 1, 20.0, "green" },
                    { 17, 17, 10.0, "green" },
                    { 16, 16, 16.0, "yellow" },
                    { 15, 15, 19.0, "green" },
                    { 14, 14, 11.0, "red" },
                    { 13, 13, 12.0, "green" },
                    { 12, 12, 19.0, "green" },
                    { 11, 11, 20.0, "Yellow" },
                    { 10, 10, 11.0, "Green" },
                    { 18, 18, 12.0, "green" },
                    { 9, 9, 10.0, "Yellow" },
                    { 6, 7, 12.0, "Green" },
                    { 8, 6, 12.0, "Green" },
                    { 5, 5, 14.0, "Green" },
                    { 3, 4, 20.0, "Yellow" },
                    { 4, 3, 10.0, "Red" },
                    { 2, 2, 20.0, "green" },
                    { 7, 8, 13.0, "Green" },
                    { 19, 19, 10.0, "red" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "TypeID", "AnimalID", "Role", "Salary" },
                values: new object[] { 1, 2, "Cleaner", 2545.0 });

            migrationBuilder.InsertData(
                table: "MedicalJournals",
                columns: new[] { "JournalID", "AnimalID", "Date", "Illness", "OptionalDetails" },
                values: new object[] { 1, 1, new DateTime(2022, 1, 2, 21, 50, 9, 170, DateTimeKind.Local).AddTicks(2134), "Diabetes", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "Age", "Name", "PhoneNumber", "TypeID" },
                values: new object[] { 1, "Libertatii", 32, "Andrei", "0745568755", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "CageID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalJournals",
                keyColumn: "JournalID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "TypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalID",
                keyValue: 2);
        }
    }
}
