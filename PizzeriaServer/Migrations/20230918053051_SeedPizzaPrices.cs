using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedPizzaPrices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO PizzaPrices (PizzaId, SizeId, Price) VALUES 
                        (1, 1, 109),
                        (1, 2, 239),
                        (1, 3, 449),
                        (2, 1, 259),
                        (2, 2, 459),
                        (2, 3, 689),
                        (3, 1, 259),
                        (3, 2, 459),
                        (3, 3, 689),
                        (4, 1, 249),
                        (4, 2, 449),
                        (4, 3, 669),
                        (5, 1, 199),
                        (5, 2, 369),
                        (5, 3, 599)
                        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE PizzaPrices");
        }
    }
}
