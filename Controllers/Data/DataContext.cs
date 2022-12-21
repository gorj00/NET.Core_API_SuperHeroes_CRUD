using Microsoft.EntityFrameworkCore;
using System.Data;

namespace NET.Core_SuperHeroes.Controllers.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }   

        public DbSet<SuperHero> SuperHeroes {  get; set; }
    }
}
