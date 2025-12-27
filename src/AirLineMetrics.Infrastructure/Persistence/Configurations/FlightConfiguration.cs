using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AirLineMetrics.Domain.Entities;

namespace AirLineMetrics.Infrastructure.Persistence.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.FlightId);
            
            builder.ToTable("Flights");


            builder.Property(f => f.FlightId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd()
                .HasColumnName("FLIGHT_ID");

            builder.Property(f => f.FlightCode)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FLIGHT_CODE");

            builder.Property(f => f.ScheduledDeparture)
                .IsRequired()
                .HasColumnName("SCHEDULED_DEPARTURE");

            builder.Property(f => f.ScheduledArrival)
                .IsRequired()
                .HasColumnName("SCHEDULED_ARRIVAL");

            builder.Property(f => f.ActualDeparture)
                   .IsRequired()
                   .HasColumnName("ACTUAL_DEPARTURE");

            builder.Property(f => f.ActualArrival)
                 .IsRequired()
                 .HasColumnName("ACTUAL_ARRIVAL");


            builder.Property(f => f.IsDeleted)
                  .IsRequired()
                  .HasColumnName("IS_DELETED");

            builder.Property(f => f.AirCraftId)
                 .IsRequired()
                 .HasColumnName("AIRCRAFT_ID");

            builder.Property(f => f.OriginAirportId)
                  .IsRequired()
                  .HasColumnName("ORIGINAL_AIRPORT_ID");

            builder.Property(f => f.DestinationAirportId)
                   .IsRequired()
                   .HasColumnName("DESTINATION_AIRPORT_ID");

            builder.Property(f => f.StateId)
                   .IsRequired()
                   .HasColumnName("STATE_ID");


            builder.HasOne(f => f.AirCraftNavigation)
                .WithMany(a => a.FlightsNavigation)
                .HasForeignKey(f => f.AirCraftId)
                .HasConstraintName("FK_FLIGHTS_AIRCRAFTS");

            builder.HasOne(f => f.OriginAirportNavigation)
                .WithMany(a => a.OriginFlightNavigation)
                .HasForeignKey(f => f.OriginAirportId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_FLIGHTS_AIRPORTS_ORIGIN");

            builder.HasOne(f => f.DestinationAirportNavigation)
                .WithMany(a => a.DestinationFlightNavigation)
                .HasForeignKey(f => f.DestinationAirportId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_FLIGHTS_AIRPORTS_DESTINATION");

            builder.HasOne(f => f.StateNavigation)
               .WithMany(s => s.FlightNavigation)
               .HasForeignKey(fd => fd.StateId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_FLIGHTS_STATES");

            builder.HasMany(f => f.FlightDetailsNavigation)
                .WithOne(fd => fd.FlightNavigation)
                .HasForeignKey(fd => fd.FlightId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.OperationalCostsNavigation)
                .WithOne(oc => oc.FlightNavigation)
                .HasForeignKey(oc => oc.FlightId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.FlightPromotionsNavigation)
                .WithOne(fp => fp.FlightNavigation)
                .HasForeignKey(fp => fp.FlightId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}