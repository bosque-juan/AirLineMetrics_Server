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
                .HasDefaultValue(1)
                .HasColumnName("COUNTRY_ID");

            builder.HasOne(s => s.CountryNavigation).WithMany(c => c.StateNavigation)
                .HasForeignKey(s => s.CountryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_STATES_COUNTRIES");
        }
    }
}
