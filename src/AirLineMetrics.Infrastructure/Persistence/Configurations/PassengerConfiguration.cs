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
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasKey(p => p.PassengerId);

            builder.ToTable("PASSENGERS");

            builder.Property(p => p.PassengerId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("PASSENGER_ID");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME");

            builder.Property(p => p.Surname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("SURNAME");

            builder.Property(p => p.Street)
                .HasMaxLength(70)
                .HasColumnName("STREET");

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnName("email");

            builder.Property(p => p.MobileNumber)
                .IsRequired()
                .HasColumnName("MOBILE_NUMBER");

            builder.Property(p => p.IsActive)
                .IsRequired()
                .HasDefaultValue(true)
                .HasColumnName("IS_ACTIVE");

            builder.Property(p => p.DocumentTypeId)
                .IsRequired()
                .HasColumnName("DOCUMENT_TYPE_ID");

            builder.Property(p => p.PassengerTypeId)
                .IsRequired()
                .HasColumnName("PASSENGER_TYPE_ID");

            builder.Property(p => p.StateId)
                 .IsRequired()
                 .HasColumnName("STATE_ID");

            builder.HasOne(p => p.DocumentTypeNavigation).WithMany(dt => dt.PassengerNavigation)
                .HasForeignKey(p => p.DocumentTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PASSENGERS_DOCUMENT_TYPES");

            builder.HasOne(p => p.PassengerTypeNavigation).WithMany(pt => pt.PassengerNavigation)
                .HasForeignKey(p => p.PassengerTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PASSENGERS_PASSENGER_TYPES");

            builder.HasOne(p => p.StateNavigation).WithMany(s => s.PassengersNavigation)
                .HasForeignKey(p => p.StateId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PASSENGERS_STATES");

        }


    }
}
