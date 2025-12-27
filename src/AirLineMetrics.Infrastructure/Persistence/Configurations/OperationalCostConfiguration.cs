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
    internal class OperationalCostConfiguration : IEntityTypeConfiguration<OperationalCost>
    {
        public void Configure(EntityTypeBuilder<OperationalCost> builder)
        {
            builder.HasKey(oc => oc.Id);

            builder.ToTable("OPERATIONAL_COSTS");

            builder.Property(oc => oc.Id)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd()
                .HasColumnName("OPERATIONAL_COST_ID");

            builder.Property(oc => oc.FuelCost)
                .HasColumnType("decimal(10,2)")
                .HasColumnName("FUEL_COST");

            builder.Property(oc => oc.MaintenanceCost)
                .HasColumnType("decimal(10,2)")
                .HasColumnName("MAINTENANCE_COST");


            builder.Property(oc => oc.CrewCost)
                .HasColumnType("decimal(10,2)")
                .HasColumnName("CREW_COST");

            builder.Property(oc => oc.AirportFees)
                .HasColumnType("decimal(10,2)")
                .HasColumnName("AIRPORT_FEES");

            builder.Property(oc => oc.OperationalDate)
                .HasColumnName("OPERATIONAL_DATE");

            builder.Property(oc => oc.FlightId)
                .IsRequired()
                .HasColumnName("FLIGHT_ID");

            builder.HasOne(oc => oc.FlightNavigation).WithMany(f => f.OperationalCostsNavigation)
                .HasForeignKey(oc => oc.FlightId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OPERATIONAL_COSTS_FLIGHTS");

        }
    }
}
