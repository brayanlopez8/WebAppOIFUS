using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationOIFUS.Migrations
{
    public partial class inirtialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstadoPersona",
                table: "tblPersona",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoPersona",
                table: "tblPersona");
        }
    }
}
