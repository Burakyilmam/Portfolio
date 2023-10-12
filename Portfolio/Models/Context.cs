using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Portfolio.Models
{
        public class Context : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-EVJH8OQ;database=PorfolioDb;integrated security=true");
            }
            public DbSet<Education> Educations { get; set; }
            public DbSet<Experience> Experiences { get; set; }
            public DbSet<Info> Infos { get; set; }
            public DbSet<Language> Languages { get; set; }
        }
    }

