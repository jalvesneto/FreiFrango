using Microsoft.EntityFrameworkCore;
using FreiFrango.DAL.Models;

public partial class FreiFrangoContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Produto> Produtos { get; set; }

    public DbSet<Cart> Cart { get; set; }

    public DbSet<BuyLater> BuyLater { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if (!optionsBuilder.IsConfigured)
        {
            String ConnectionString = "Server=localhost;User Id=root;Password=;Database=FreiFrango";
            optionsBuilder.UseMySql(ConnectionString, ServerVersion.Parse("10.4.22"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
