using Microsoft.EntityFrameworkCore.Migrations;

namespace aiutu.Infrastructure.Migrations
{
    public partial class Kontrahenci20220526 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CEOLastName",
                table: "Kontrahenci",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEOName",
                table: "Kontrahenci",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CzyAktywny",
                table: "Kontrahenci",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Regon",
                table: "Kontrahenci",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEOLastName",
                table: "Kontrahenci");

            migrationBuilder.DropColumn(
                name: "CEOName",
                table: "Kontrahenci");

            migrationBuilder.DropColumn(
                name: "CzyAktywny",
                table: "Kontrahenci");

            migrationBuilder.DropColumn(
                name: "Regon",
                table: "Kontrahenci");
        }
    }
}
