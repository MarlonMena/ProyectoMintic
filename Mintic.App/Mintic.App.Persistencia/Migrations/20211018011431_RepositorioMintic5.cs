using Microsoft.EntityFrameworkCore.Migrations;

namespace Mintic.App.Persistencia.Migrations
{
    public partial class RepositorioMintic5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PrimerRegistro",
                table: "Personas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimerRegistro",
                table: "Personas");
        }
    }
}
