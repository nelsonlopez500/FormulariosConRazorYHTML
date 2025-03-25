using Microsoft.EntityFrameworkCore;

namespace FormulariosConRazorYHTML.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions<equiposDbContext> options) : base(options)
        {
        }

        public DbSet<marcas> marcas { get; set; }
    }
}