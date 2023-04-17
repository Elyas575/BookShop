using BookStuff.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BookStuff.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
        public DbSet<Category> Categories { get; set; }

    }
}
