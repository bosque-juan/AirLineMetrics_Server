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
    internal class SeatReservationConfiguration : IEntityTypeConfiguration<SeatReservation>
    {
        public void Configure(EntityTypeBuilder<SeatReservation> builder)
        {
            builder.HasKey(s => s.SeatId);

            builder.ToTable("SEATS");

            builder.Property(s => s.SeatId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("SEAT_ID");

            builder.Property(s => s.Number)
                .IsRequired()
                .HasColumnName("SEAT_NUMBER");

            builder.Property(s => s.IsBussy)
                .IsRequired()
                .HasColumnName("IS_BUSY");

            builder.Property(s => s.SeatTypeId)
                .IsRequired()
                .HasColumnName("SEAT_TYPE_ID");

            builder.Property(s => s.FlighDetailtId)
                .IsRequired()
                .HasColumnName("FLIGHT_DETAIL_ID");


            builder.HasOne(sr => sr.FlightDetailNavigation).WithMany(fd => fd.SeatReservationNavigation)
                .HasForeignKey(sr => sr.FlighDetailtId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SEAT_RESERVATIONS_FLIGHT_DETAILS");

            builder.HasOne(sr => sr.SeatTypeNavigation).WithMany(st => st.SeatReservationNavigation)
                .HasForeignKey(sr => sr.SeatTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SEAT_RESERVATIONS_SEAT_TYPES");
        }
    }
}
