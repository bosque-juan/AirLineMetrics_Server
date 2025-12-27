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
    internal class PurchaseCancellationConfiguration : IEntityTypeConfiguration<PurchaseCancellation>
    {
        public void Configure(EntityTypeBuilder<PurchaseCancellation> builder)
        {
            builder.HasKey(c => c.CancellationId);

            builder.ToTable("PURCHASE_CANCELLATIONS");

            builder.Property(c => c.CancellationId)
                    .UseIdentityColumn(1, 1)
                    .HasColumnName("CANCELLATION_ID");

            builder.Property(c => c.RefundAmount)
                .HasColumnName("REFOUND_AMOUNT");

            builder.Property(c => c.CancellationDate)
                .HasColumnName("DATE");

            builder.Property(c => c.SatisfactionEstimated)
                .HasColumnName("SATISFACTION_ESTIMATED");

            builder.Property(c => c.CancellationReasonId)
           .IsRequired()
           .HasColumnName("CANCELLATION_REASSON_ID");

            builder.Property(c => c.InvoiceDetailId)
                .IsRequired()
                .HasColumnName("INVOICE_DETAIL_ID");

            builder.HasOne(pc => pc.InvoiceDetailNavigation).WithMany(id => id.PurchaseCancellationNavigation)
                .HasForeignKey(pc => pc.InvoiceDetailId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PURCHASE_CANCELLATIONS_INVOICE_DETAILS");

            builder.HasOne(pc => pc.CancellationReassonNavigation).WithMany(cr => cr.PurchaseCancellationNavigation)
                .HasForeignKey(pc => pc.CancellationReasonId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PURCHASE_CANCELLATIONS_CANCELLATION_REASONS");
        }
    }
}
