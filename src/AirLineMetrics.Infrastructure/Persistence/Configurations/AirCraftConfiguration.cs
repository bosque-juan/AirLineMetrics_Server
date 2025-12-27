using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AirLineMetrics.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Infrastructure.Persistence.Configurations
{
    internal class AirCraftConfiguration : IEntityTypeConfiguration<AirCraft>
    {
        public void Configure(EntityTypeBuilder<AirCraft> builder)
        {
            builder.HasKey(ac => ac.AirCraftId);

            builder.ToTable("AIRCRAFT");

            builder.Property(ar => ar.AirCraftId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("AIRCRAFT_ID");

            builder.Property(ar => ar.AirCraftName)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("NAME");

            builder.Property(ar => ar.PassengerCapacity)
                .IsRequired()
                .HasColumnName("CAPACITY");

            builder.HasMany(a => a.FlightsNavigation)
                .WithOne(f => f.AirCraftNavigation)
                .HasForeignKey(f => f.AirCraftId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
