using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LektionsVinylCollection.Migrations
{
    public partial class Seed_Data_For_Artist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "FavoriteCar", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 13, 10, 25, 35, 660, DateTimeKind.Local).AddTicks(6616), "Car 1", "Artist 1" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "FavoriteCar", "Name" },
                values: new object[] { 2, new DateTime(2021, 12, 13, 10, 25, 35, 660, DateTimeKind.Local).AddTicks(6656), "Car 2", "Artist 2" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "FavoriteCar", "Name" },
                values: new object[] { 3, new DateTime(2021, 12, 13, 10, 25, 35, 660, DateTimeKind.Local).AddTicks(6658), "Car 3", "Artist 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
