using Microsoft.EntityFrameworkCore;
using PlatformServices.Models;

namespace PlatformService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        public DbSet<Platform> Platsforms { get; set; }
    }
}