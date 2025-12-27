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
    internal class SeatTypeConfiguration : IEntityTypeConfiguration<SeatType>
    {
        public void Configure(EntityTypeBuilder<SeatType> builder)
        {
            builder.ToTable("SEAT_TYPES");

            builder.HasKey(st => st.SeatTypeId);

            builder.Property(st => st.SeatTypeId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("SEAT_TYPE_ID");

            builder.Property(st => st.SeatName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("SEAT_NAME");

            builder.Property(st => st.Description)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPTION");

            builder.Property(st => st.AddedSeatTypePrice)
                .IsRequired()
                .HasColumnName("ADDED_SEAT_TYPE_PRICE");

            builder.HasMany(st => st.SeatReservationNavigation)
                .WithOne(sr => sr.SeatTypeNavigation)
                .HasForeignKey(sr => sr.SeatTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
