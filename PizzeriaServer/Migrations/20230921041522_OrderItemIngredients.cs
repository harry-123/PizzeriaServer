using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaServer.Migrations
{
    /// <inheritdoc />
    public partial class OrderItemIngredients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemIngredient_Ingredients_IngredientId",
                table: "OrderItemIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemIngredient_OrderItems_OrderItemId",
                table: "OrderItemIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItemIngredient",
                table: "OrderItemIngredient");

            migrationBuilder.RenameTable(
                name: "OrderItemIngredient",
                newName: "OrderItemIngredients");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemIngredient_OrderItemId",
                table: "OrderItemIngredients",
                newName: "IX_OrderItemIngredients_OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemIngredient_IngredientId",
                table: "OrderItemIngredients",
                newName: "IX_OrderItemIngredients_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItemIngredients",
                table: "OrderItemIngredients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemIngredients_Ingredients_IngredientId",
                table: "OrderItemIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemIngredients_OrderItems_OrderItemId",
                table: "OrderItemIngredients",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemIngredients_Ingredients_IngredientId",
                table: "OrderItemIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemIngredients_OrderItems_OrderItemId",
                table: "OrderItemIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItemIngredients",
                table: "OrderItemIngredients");

            migrationBuilder.RenameTable(
                name: "OrderItemIngredients",
                newName: "OrderItemIngredient");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemIngredients_OrderItemId",
                table: "OrderItemIngredient",
                newName: "IX_OrderItemIngredient_OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemIngredients_IngredientId",
                table: "OrderItemIngredient",
                newName: "IX_OrderItemIngredient_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItemIngredient",
                table: "OrderItemIngredient",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemIngredient_Ingredients_IngredientId",
                table: "OrderItemIngredient",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemIngredient_OrderItems_OrderItemId",
                table: "OrderItemIngredient",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
