using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    }
}