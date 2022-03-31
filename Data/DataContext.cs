using HeroProjectAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HeroProjectAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
