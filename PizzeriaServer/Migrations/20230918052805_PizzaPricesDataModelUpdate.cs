using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaServer.Migrations
{
    /// <inheritdoc />
    public partial class PizzaPricesDataModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PizzaPrices_SizeId",
                table: "PizzaPrices");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaPrices_SizeId",
                table: "PizzaPrices",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PizzaPrices_SizeId",
                table: "PizzaPrices");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaPrices_SizeId",
                table: "PizzaPrices",
                column: "SizeId",
                unique: true);
        }
    }
}
