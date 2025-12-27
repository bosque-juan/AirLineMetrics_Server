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
    internal class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(i => i.InvoiceId);

            builder.ToTable("INVOICES");

            builder.Property(i => i.InvoiceId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd()
                .HasColumnName("INVOICE_ID");

            builder.Property(i => i.Date)
                .IsRequired()
                .HasColumnName("DATE");

            builder.Property(i => i.PassengerId)
                .IsRequired()
                .HasColumnName("PASSENGER_ID");

            builder.HasOne(i => i.PassengerNavigation).WithMany(p => p.InvoiceNavigation)
                .HasForeignKey(i => i.PassengerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_INVOICES_PASSENGERS");

            builder.HasMany(i => i.InvoicePaymentNavigation)
                .WithOne(ip => ip.InvoiceNavigation)
                .HasForeignKey(ip => ip.InvoiceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(i => i.InvoiceDetailNavigation)
             .WithOne(id => id.InvoiceNavigation)
             .HasForeignKey(id => id.InvoiceId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
