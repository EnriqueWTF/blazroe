using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazroe.Migrations
{
    /// <inheritdoc />
    public partial class AgregarArchivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Archivada",
                table: "Facturas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Archivada",
                table: "Facturas");
        }
    }
}
