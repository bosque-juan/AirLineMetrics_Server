using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AirLineMetrics.Domain.Entities;

namespace AirLineMetrics.Infrastructure.Persistence.Configurations
{
    internal class InvoiceDetailConfiguration : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.HasKey(id => id.InvoiceDetailId);

            builder.ToTable("INVOICE_DETAILS");

            builder.Property(id => id.InvoiceDetailId)
                    .UseIdentityColumn()
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INVOICE_DETAIL_ID");

            builder.Property(id => id.Price)
                    .IsRequired()
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("PRICE");

            builder.Property(id => id.InvoiceId)
                    .IsRequired()
                    .HasColumnName("INVOICE_ID");

            builder.Property(id => id.FlightDetailId)
                    .IsRequired()
                    .HasColumnName("FLIGHT_DETAIL_ID");

            builder.HasOne(id => id.InvoiceNavigation).WithMany(i => i.InvoiceDetailNavigation)
                    .HasForeignKey(id => id.InvoiceId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK_INVOICE_DETAILS_INVOICES");

            builder.HasOne(id => id.FlightDetailNavigation).WithMany(fd => fd.InvoiceDetailNavigation)
                    .HasForeignKey(id => id.FlightDetailId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK_INVOICE_DETAILS_FLIGHT_DETAILS");

     
        }
    }
}
