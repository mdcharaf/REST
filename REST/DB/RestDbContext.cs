using Microsoft.EntityFrameworkCore;
using REST.Models;

namespace REST.DB
{
    public class RestDbContext : DbContext
    {
        public RestDbContext(DbContextOptions<RestDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
    }
}