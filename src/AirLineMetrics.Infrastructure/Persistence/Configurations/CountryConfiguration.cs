using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AirLineMetrics.Domain.Entities;

namespace AirLineMetrics.Infrastructure.Persistence.Configurations
{
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("COUNTRIES");
            builder.HasKey(c => c.CountryId);

            builder.Property(c => c.CountryId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("COUNTRY_ID");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("COUNTRY_NAME");

            builder.HasMany(c => c.StateNavigation)
                    .WithOne(s => s.CountryNavigation)
                    .HasForeignKey(s => s.CountryId)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
