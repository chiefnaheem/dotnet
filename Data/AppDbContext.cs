using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }
        // DbSet is a collection of objects that represent a table in the database
        public DbSet<Platform> Platforms { get; set; }
    }
}