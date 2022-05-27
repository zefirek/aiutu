using Microsoft.EntityFrameworkCore.Migrations;

namespace aiutu.Infrastructure.Migrations
{
    public partial class kontrahent_aktualizacja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CzyAktywny",
                table: "Kontrahenci",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Kontrahenci",
                newName: "CzyAktywny");
        }
    }
}
