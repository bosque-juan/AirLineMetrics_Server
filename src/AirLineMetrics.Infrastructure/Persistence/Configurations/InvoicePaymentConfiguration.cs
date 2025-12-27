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

    internal class InvoicePaymentConfiguration : IEntityTypeConfiguration<InvoicePayment>
    {
        public void Configure(EntityTypeBuilder<InvoicePayment> builder)
        {
            builder.HasKey(p => p.PaymentId);

            builder.ToTable("INVOICE_PAYMENTS");

            builder.Property(p => p.PaymentId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("PAYMENT_ID");

            builder.Property(p => p.PaymentAmount)
                .HasColumnName("AMOUNT");

            builder.Property(p => p.PaymentDate)
                .HasColumnName("PAYMENT_DATE");

            builder.Property(p => p.PaymentMethodId)
                .IsRequired()
                .HasColumnName("PAYMENT_METHOD_ID");

            builder.Property(p => p.InvoiceId)
                .IsRequired()
                .HasColumnName("INVOICE_ID");

            builder.HasOne(p => p.PaymentMethodNavigation).WithMany(pm => pm.InvoicePaymentNavigation)
                .HasForeignKey(p => p.PaymentMethodId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_INVOICE_PAYMENT_PAYMENTE_METHOD_ID");

            builder.HasOne(p => p.InvoiceNavigation).WithMany(i => i.InvoicePaymentNavigation)
                .HasForeignKey(p => p.InvoiceId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_INVOICE_PAYMENT_INVOICE_ID");
        }
    }
}
