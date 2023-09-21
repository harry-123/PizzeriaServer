using Microsoft.EntityFrameworkCore;
using PizzeriaServer.Models;

namespace PizzeriaServer.DbContext;

public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<PizzaSize> PizzaSizes { get; set; }
    public DbSet<PizzaPrice> PizzaPrices { get; set; }
    public DbSet<IngredientType> IngredientTypes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<IngredientPrice> IngredientPrices { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<OrderItemIngredient> OrderItemIngredients { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Pizza>()
            .Property(x => x.Id)
            .UseIdentityColumn();
        builder.Entity<Pizza>()
            .Property(x => x.Name)
            .IsRequired();
        builder.Entity<Pizza>()
            .Property(x => x.Description)
            .IsRequired();
        builder.Entity<Pizza>()
            .Property(x => x.ThumbnailPath)
            .IsRequired();
        
        builder.Entity<PizzaSize>()
            .Property(x => x.Id)
            .UseIdentityColumn();
        builder.Entity<PizzaSize>()
            .Property(x => x.Name)
            .IsRequired();

        builder.Entity<PizzaPrice>()
            .HasOne(x => x.Pizza)
            .WithMany(x => x.Prices)
            .HasForeignKey(x => x.PizzaId)
            .IsRequired();
        builder.Entity<PizzaPrice>()
            .HasOne(x => x.PizzaSize)
            .WithMany(x => x.PizzaPrices)
            .HasForeignKey(x => x.SizeId)
            .IsRequired();
        builder.Entity<PizzaPrice>()
            .Property(x => x.Price)
            .IsRequired();

        builder.Entity<IngredientType>()
            .Property(x => x.Id)
            .UseIdentityColumn();
        builder.Entity<IngredientType>()
            .Property(x => x.Name)
            .IsRequired();

        builder.Entity<Ingredient>()
            .Property(x => x.Id)
            .UseIdentityColumn();
        builder.Entity<Ingredient>()
            .Property(x => x.Name)
            .IsRequired();
        builder.Entity<Ingredient>()
            .HasOne(x => x.IngredientType)
            .WithMany(x => x.Ingredients)
            .HasForeignKey(x => x.IngredientTypeId)
            .IsRequired();
        
        builder.Entity<IngredientPrice>()
            .Property(x => x.Id)
            .UseIdentityColumn();
        builder.Entity<IngredientPrice>()
            .HasOne(x => x.Ingredient)
            .WithMany(x => x.IngredientPrices)
            .HasForeignKey(x => x.IngredientId)
            .IsRequired();
        builder.Entity<IngredientPrice>()
            .HasOne(x => x.PizzaSize)
            .WithMany(x => x.IngredientPrices)
            .HasForeignKey(x => x.SizeId)
            .IsRequired();
        builder.Entity<IngredientPrice>()
            .Property(x => x.Price)
            .IsRequired();
        
        builder.Entity<Order>()
            .Property(x => x.Id)
            .UseIdentityColumn();
        builder.Entity<Order>()
            .Property(x => x.OrderValue)
            .IsRequired();
        builder.Entity<Order>()
            .Property(x => x.DeliveryAddress)
            .IsRequired();
        
        builder.Entity<OrderItem>()
            .Property(x => x.Id)
            .UseIdentityColumn();
        builder.Entity<OrderItem>()
            .HasOne<Order>(x => x.Order)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.OrderId)
            .IsRequired();
        builder.Entity<OrderItem>()
            .HasOne<Pizza>(x => x.Pizza)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.PizzaId)
            .IsRequired();
        builder.Entity<OrderItem>()
            .HasOne<PizzaSize>(x => x.PizzaSize)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.SizeId)
            .IsRequired();
        builder.Entity<OrderItem>()
            .Property(x => x.Quantity)
            .IsRequired();
        builder.Entity<OrderItem>()
            .Property(x => x.NetPrice)
            .IsRequired();
        
        builder.Entity<OrderItemIngredient>()
            .Property(x => x.Id)
            .UseIdentityColumn();
        builder.Entity<OrderItemIngredient>()
            .HasOne<OrderItem>(x => x.OrderItem)
            .WithMany(x => x.OrderItemIngredients)
            .HasForeignKey(x => x.OrderItemId)
            .IsRequired();
        builder.Entity<OrderItemIngredient>()
            .HasOne<Ingredient>(x => x.Ingredient)
            .WithMany(x => x.OrderItemIngredients)
            .HasForeignKey(x => x.IngredientId)
            .IsRequired();
        
        
        
        
        base.OnModelCreating(builder);
    }
}