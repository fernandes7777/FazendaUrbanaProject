using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FazendaUrbana.Forms.Migrations
{
    /// <inheritdoc />
    public partial class AdicaoDeColunaNome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "taxId",
                table: "Suppliers",
                newName: "TaxId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "TaxId",
                table: "Suppliers",
                newName: "taxId");
        }
    }
}
