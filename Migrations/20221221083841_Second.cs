using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET.Core_SuperHeroes.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperHeroe",
                table: "SuperHeroe");

            migrationBuilder.RenameTable(
                name: "SuperHeroe",
                newName: "SuperHeroes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperHeroes",
                table: "SuperHeroes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperHeroes",
                table: "SuperHeroes");

            migrationBuilder.RenameTable(
                name: "SuperHeroes",
                newName: "SuperHeroe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperHeroe",
                table: "SuperHeroe",
                column: "Id");
        }
    }
}
