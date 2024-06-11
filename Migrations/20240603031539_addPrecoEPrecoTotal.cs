using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FazendaUrbana.Forms.Migrations
{
    /// <inheritdoc />
    public partial class addPrecoEPrecoTotal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "QuantityProduced",
                table: "ProductionProducts",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "ProductionProducts",
                type: "decimal(65,30)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "ProductionProducts");

            migrationBuilder.AlterColumn<float>(
                name: "QuantityProduced",
                table: "ProductionProducts",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);
        }
    }
}
