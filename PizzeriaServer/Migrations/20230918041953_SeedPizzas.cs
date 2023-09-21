using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedPizzas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Pizzas 
                (Name, Description, ThumbnailPath) 
                VALUES
                ('Margherita', 'Classic delight with 100% real mozzarella cheese', 'margherita.jpg'),
                ('Farmhouse', 'Delightful combination of onion, capsicum, tomato & grilled mushroom', 'farmhouse.png'),
                ('Peppy Paneer', 'Flavorful trio of juicy paneer, crisp capsicum with spicy red paprika', 'peppy_paneer.jpg'),
                ('Pepper Barbecue Chicken', 'Pepper barbecue chicken for that extra zing', 'pepper_barbeque_chicken.jpg'),
                ('Chicken Sausage', 'American classic! Spicy, herbed chicken sausage on pizza', 'chicken_sausage.jpg')
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Pizzas");
        }
    }
}
