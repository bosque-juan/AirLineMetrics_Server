using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLineMetrics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirLineMetrics.Infrastructure.Persistence.Configurations
{
    internal class PassengerTypeConfiguration : IEntityTypeConfiguration<PassengerType>
    {
        public void Configure(EntityTypeBuilder<PassengerType> builder)
        {
            builder.ToTable("PASSENGER_TYPES");

            builder.HasKey(pt => pt.PassengerTypeId);

            builder.Property(p => p.PassengerTypeId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("PASSENGER_TYPE_ID");

            builder.Property(p => p.Description)
                .HasMaxLength(100)
                .HasColumnName("DESCRIPTION");

            builder.HasMany(pt => pt.PassengersNavigation)
                .WithOne(p => p.PassengerTypeNavigation)
                .HasForeignKey(p => p.PassengerTypeId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
