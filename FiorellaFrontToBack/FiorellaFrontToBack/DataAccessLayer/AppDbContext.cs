using FiorellaFrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorellaFrontToBack.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AboutSection> Abouts { get; set; }
        public DbSet<AboutSectionServices> Services { get; set; }
        public DbSet<ExpertSection> ExpertSections { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}
