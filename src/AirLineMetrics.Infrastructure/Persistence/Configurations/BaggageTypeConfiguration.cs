using AirLineMetrics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Infrastructure.Persistence.Configurations
{
    internal class BaggageTypeConfiguration : IEntityTypeConfiguration<BaggageType>
    {
        public void Configure(EntityTypeBuilder<BaggageType> builder)
        {
            builder.HasKey(bt => bt.BaggageTypeId);

            builder.ToTable("BAGGAGE_TYPES");

            builder.Property(p => p.BaggageTypeId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("BAGGAGE_TYPE_ID");

            builder.Property(p => p.BaggageName)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("DESCRIPTION");

            builder.HasMany(bt => bt.BaggageReservationNavigation)
                .WithOne(br => br.BaggageTypeNavigation)
                .HasForeignKey(br => br.BaggageTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
