using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaServer.Migrations
{
    /// <inheritdoc />
    public partial class OrderItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemIngredients_Ingredients_IngredientId",
                table: "OrderItemIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemIngredients_OrderItems_OrderItemId",
                table: "OrderItemIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_PizzaSizes_PizzaSizeId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_PizzaSizeId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItemIngredients",
                table: "OrderItemIngredients");

            migrationBuilder.DropColumn(
                name: "PizzaSizeId",
                table: "OrderItems");

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_SizeId",
                table: "OrderItems",
                column: "SizeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_PizzaSizes_SizeId",
                table: "OrderItems",
                column: "SizeId",
                principalTable: "PizzaSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemIngredient_Ingredients_IngredientId",
                table: "OrderItemIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemIngredient_OrderItems_OrderItemId",
                table: "OrderItemIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_PizzaSizes_SizeId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_SizeId",
                table: "OrderItems");

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

            migrationBuilder.AddColumn<int>(
                name: "PizzaSizeId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItemIngredients",
                table: "OrderItemIngredients",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_PizzaSizeId",
                table: "OrderItems",
                column: "PizzaSizeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_PizzaSizes_PizzaSizeId",
                table: "OrderItems",
                column: "PizzaSizeId",
                principalTable: "PizzaSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
