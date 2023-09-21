using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedIngredientPrices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO IngredientPrices (IngredientId, SizeId, Price) VALUES
                                                            (1, 1, 0),
                                                            (1, 2, 0),
                                                            (1, 3, 0),
                                                            (2, 1, 10),
                                                            (2, 2, 15),
                                                            (2, 3, 20),
                                                            (3, 1, 15),
                                                            (3, 2, 20),
                                                            (3, 3, 25),
                                                            (4, 1, 20),
                                                            (4, 2, 25),
                                                            (4, 3, 30),
                                                            (5, 1, 25),
                                                            (5, 2, 30),
                                                            (5, 3, 35),
                                                            (6, 1, 0),
                                                            (6, 2, 0),
                                                            (6, 3, 0),
                                                            (7, 1, 35),
                                                            (7, 2, 50),
                                                            (7, 3, 70),
                                                            (8, 1, 20),
                                                            (8, 2, 30),
                                                            (8, 3, 40),
                                                            (9, 1, 20),
                                                            (9, 2, 30),
                                                            (9, 3, 40),
                                                            (10, 1, 20),
                                                            (10, 2, 30),
                                                            (10, 3, 40),
                                                            (11, 1, 20),
                                                            (11, 2, 30),
                                                            (11, 3, 40),
                                                            (12, 1, 20),
                                                            (12, 2, 30),
                                                            (12, 3, 40),
                                                            (13, 1, 30),
                                                            (13, 2, 40),
                                                            (13, 3, 50),
                                                            (14, 1, 30),
                                                            (14, 2, 40),
                                                            (14, 3, 50),
                                                            (15, 1, 30),
                                                            (15, 2, 40),
                                                            (15, 3, 50)
                                                               ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE IngredientPrices");
        }
    }
}
