using E_Shop.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Shop.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
