using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLineMetrics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirLineMetrics.Infrastructure.Persistence
{
    public class AirLinceMetricsDbContext(DbContextOptions<AirLinceMetricsDbContext> options) : DbContext(options)
    {
        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<BaggageReservation> BaggageReservations { get; set; }
        public DbSet<BaggageType> BaggageTypes { get; set; }
        public DbSet<CancellationReason> CancellationReasons { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightDetail> FlightDetails { get; set; }
        public DbSet<FlightPromotion> FlightPromotions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<InvoicePayment> InvoicePayments { get; set; }
        public DbSet<OperationalCost> OperationalCosts { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<PassengerType> PassengerTypes { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PurchaseCancellation> PurchaseCancellations { get; set; }
        public DbSet<SeatReservation> SeatReservations { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AirLinceMetricsDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
