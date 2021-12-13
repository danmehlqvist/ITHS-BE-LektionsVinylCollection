using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LektionsVinylCollection.Migrations
{
    public partial class Seed_Data_For_Vinyls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.InsertData(
                table: "Vinyls",
                columns: new[] { "Id", "ArtistID", "Created", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4571), "Title 1" },
                    { 2, 2, new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4574), "Title 2" },
                    { 3, 2, new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4576), "Title 3" },
                    { 4, 3, new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4577), "Title 4" },
                    { 5, 3, new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4578), "Title 5" },
                    { 6, 3, new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4580), "Title 6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 13, 10, 25, 35, 660, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 13, 10, 25, 35, 660, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 13, 10, 25, 35, 660, DateTimeKind.Local).AddTicks(6658));
        }
    }
}
