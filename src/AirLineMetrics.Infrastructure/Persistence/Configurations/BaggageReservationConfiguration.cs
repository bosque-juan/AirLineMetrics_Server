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
    internal class BaggageReservationConfiguration : IEntityTypeConfiguration<BaggageReservation>
    {
        public void Configure(EntityTypeBuilder<BaggageReservation> builder)
        {
            builder.HasKey(b => b.BaggageId);

            builder.ToTable("BAGGAGES");

            builder.Property(b => b.BaggageId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("BAGGAGE_ID");

            builder.Property(b => b.Price)
                .IsRequired()
                .HasColumnName("PRICE");

            builder.Property(b => b.Weight)
                .HasColumnName("WEIGHT");

            builder.Property(b => b.BaggageTypeId)
                .IsRequired()
                .HasColumnName("BAGGAGE_TYPE_ID");

            builder.Property(b => b.FlightDetailId)
                .IsRequired()
                .HasColumnName("FLIGHT_DETAIL_ID");

            builder.HasOne(b => b.BaggageTypeNavigation).WithMany(bt => bt.BaggageNavigation)
                .HasForeignKey(bt => bt.BaggageTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BAGGAGE_BAGGAGE_TYPE");

            builder.HasOne(b => b.FlightDetailNavigation).WithMany(fd => fd.BaggageNavigation)
           .HasForeignKey(bt => bt.BaggageTypeId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_BAGGAGE_FLIGHT_DETAILS");
        }
    }
}
