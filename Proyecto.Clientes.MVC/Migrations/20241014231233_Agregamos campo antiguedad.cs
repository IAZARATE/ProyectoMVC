using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Clientes.MVC.Migrations
{
    /// <inheritdoc />
    public partial class Agregamoscampoantiguedad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Antiguedad",
                table: "Clientes",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Antiguedad",
                table: "Clientes");
        }
    }
}
