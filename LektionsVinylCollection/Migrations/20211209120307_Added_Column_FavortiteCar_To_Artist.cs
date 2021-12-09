using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LektionsVinylCollection.Migrations
{
    public partial class Added_Column_FavortiteCar_To_Artist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteCar",
                table: "Artists",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteCar",
                table: "Artists");
        }
    }
}
