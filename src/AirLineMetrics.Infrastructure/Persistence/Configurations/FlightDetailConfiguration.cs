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
    internal class FlightDetailConfiguration : IEntityTypeConfiguration<FlightDetail>
    {
        public void Configure(EntityTypeBuilder<FlightDetail> builder)
        {
            builder.Property(fd => fd.FlightDetailId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd()
                .HasColumnName("FLIGHT_DETAIL_ID");

            builder.Property(fd => fd.Date)
                .IsRequired()
                .HasColumnName("DATE");


            builder.Property(fd => fd.Price)
                .IsRequired()
                .HasColumnType("decimal(10,2)")
                .HasColumnName("PRICE");


            builder.Property(fd => fd.Description)
                .HasColumnName("DESCRIPTION");


            builder.Property(fd => fd.IsCancelled)
                .IsRequired()
                .HasColumnName("IS_CANCELLED");

            builder.Property(fd => fd.PassengerId)
                .IsRequired()
                .HasColumnName("PASSENGER_ID");

            builder.Property(fd => fd.FlightId)
                .IsRequired()
                .HasColumnName("FLIGHT_ID");


            builder.HasOne(fd => fd.PassengerNavigation).WithMany(p => p.FlightDetailsNavigation)
                    .HasForeignKey(fp => fp.PassengerId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK_FLIGHT_DETAILS_PASSENGERS");

            builder.HasOne(fd => fd.FlightNavigation).WithMany(p => p.FlightDetailsNavigation)
              .HasForeignKey(fd => fd.FlightId)
              .OnDelete(DeleteBehavior.NoAction)
              .HasConstraintName("FK_FLIGHT_DETAILS_FLIGTHS");

            builder.HasMany(fd => fd.SeatReservationNavigation)
               .WithOne(sr => sr.FlightDetailNavigation)
               .HasForeignKey(sr => sr.FlighDetailtId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(fd => fd.BaggageReservationNavigation)
               .WithOne(br => br.FlightDetailNavigation)
               .HasForeignKey(br => br.FlightDetailId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(fd => fd.InvoiceDetailNavigation)
            .WithOne(id => id.FlightDetailNavigation)
            .HasForeignKey(id => id.FlightDetailId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
