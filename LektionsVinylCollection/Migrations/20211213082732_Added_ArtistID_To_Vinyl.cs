using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LektionsVinylCollection.Migrations
{
    public partial class Added_ArtistID_To_Vinyl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Vinyls");

            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "Vinyls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vinyls_ArtistID",
                table: "Vinyls",
                column: "ArtistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_Artists_ArtistID",
                table: "Vinyls",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_Artists_ArtistID",
                table: "Vinyls");

            migrationBuilder.DropIndex(
                name: "IX_Vinyls_ArtistID",
                table: "Vinyls");

            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "Vinyls");

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Vinyls",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
