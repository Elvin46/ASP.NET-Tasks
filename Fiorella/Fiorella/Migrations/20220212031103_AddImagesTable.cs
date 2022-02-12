using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorella.Migrations
{
    public partial class AddImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InstagramImages",
                table: "InstagramImages");

            migrationBuilder.RenameTable(
                name: "InstagramImages",
                newName: "Instagrams");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instagrams",
                table: "Instagrams",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instagrams",
                table: "Instagrams");

            migrationBuilder.RenameTable(
                name: "Instagrams",
                newName: "InstagramImages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstagramImages",
                table: "InstagramImages",
                column: "Id");
        }
    }
}
