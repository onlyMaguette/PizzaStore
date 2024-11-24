using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Models
{
    public class PizzaEhod
    {
        public int IdEhod { get; set; }
        public string? NomEhod { get; set; }
        public string? DescriptionEhod { get; set; }
    }

    class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions options) : base(options) { }
        public DbSet<PizzaEhod> Pizzas { get; set; } = null!;
    }
}
