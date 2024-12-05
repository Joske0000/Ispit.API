using Microsoft.EntityFrameworkCore;
using Ispit.API.Models;

namespace Ispit.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ShoppingItem> ShoppingItems { get; set; }
    }
}