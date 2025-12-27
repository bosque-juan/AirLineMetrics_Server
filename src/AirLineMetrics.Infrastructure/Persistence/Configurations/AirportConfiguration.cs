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
    internal class AirportConfiguration : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            builder.HasKey(a=>a.AirportId);

            builder.ToTable("AIRPORTS");

            builder.Property(a => a.AirportId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd()
                .HasColumnName("AIRPORT_ID");

            builder.Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Name");


            builder.Property(a => a.StateId)
                .IsRequired()
                .HasColumnName("STATE_ID");

            builder.HasOne(a => a.StateNavigation).WithMany(s => s.AiportsNavigation)
                .HasForeignKey(a => a.StateId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AIRPORTS_STATES");
        }
    }
}
