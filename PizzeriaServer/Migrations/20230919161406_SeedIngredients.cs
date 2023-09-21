using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedIngredients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Ingredients (Name, IngredientTypeId) VALUES 
                                                     ('Classic Mariana Sauce', 1),
                                                     ('Cheese Sauce', 1),
                                                     ('Ranch Sauce', 1),
                                                     ('BBQ Sauce', 1),
                                                     ('Pesto Sauce', 1),
                                                     ('Normal Cheese', 2),
                                                     ('Extra Cheese', 2),
                                                     ('Bell Peppers', 3),
                                                     ('Mushrooms', 3),
                                                     ('Black Olives', 3),
                                                     ('Cherry Tomatoes', 3),
                                                     ('Jalepenoes', 3),
                                                     ('Chicken Tikka', 3),
                                                     ('Pepperoni', 3),
                                                     ('Chicken Sausages', 3)
                                                     ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"TRUNCATE TABLE Ingredients");
        }
    }
}
