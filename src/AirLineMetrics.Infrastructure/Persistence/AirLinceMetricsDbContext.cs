using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLineMetrics.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirLineMetrics.Infrastructure.Persistence
{
    public class AirLinceMetricsDbContext(DbContextOptions<AirLinceMetricsDbContext> options) : DbContext(options)
    {
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AirLinceMetricsDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
