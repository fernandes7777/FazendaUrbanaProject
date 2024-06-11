using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FazendaUrbana.Forms.Migrations
{
    /// <inheritdoc />
    public partial class TrocandoCampoParaDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PurchasePrice",
                table: "SupplierInputs",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "SupplierInputs",
                keyColumn: "PaymentTerms",
                keyValue: null,
                column: "PaymentTerms",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTerms",
                table: "SupplierInputs",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PurchasePrice",
                table: "SupplierInputs",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTerms",
                table: "SupplierInputs",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
