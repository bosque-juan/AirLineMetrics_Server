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
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasKey(s => s.StateId);

            builder.ToTable("STATES");

            builder.Property(s => s.StateId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("STATE_ID");

            builder.Property(s => s.StateName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("STATE_NAME");

            builder.Property(s => s.CountryId)
                .IsRequired()
                .HasColumnName("COUNTRY_ID");

            builder.HasOne(s => s.CountryNavigation).WithMany(c => c.StateNavigation)
                .HasForeignKey(s => s.CountryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_STATES_COUNTRIES");

            builder.HasMany(s => s.PassengersNavigation)
                .WithOne(p => p.StateNavigation)
                .HasForeignKey(p => p.StateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(s => s.FlightNavigation)
                .WithOne(f => f.StateNavigation)
                .HasForeignKey(f => f.StateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(s => s.AiportsNavigation)
                .WithOne(a => a.StateNavigation)
                .HasForeignKey(a => a.StateId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
