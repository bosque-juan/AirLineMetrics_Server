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
    internal class CancellationReassonConfiguration : IEntityTypeConfiguration<CancellationReason>
    {
        public void Configure(EntityTypeBuilder<CancellationReason> builder)
        {
            builder.HasKey(cr => cr.CancellationReasonId);

            builder.ToTable("CANCELLATION_REASSONS");

            builder.Property(cr => cr.CancellationReasonId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd()
                .HasColumnName("CANCELLATION_REASSON_ID");

            builder.Property(cr => cr.Description)
                .HasMaxLength(100)
                .HasColumnName("Description");

            builder.HasMany(cr => cr.PurchaseCancellationNavigation)
                .WithOne(pc => pc.CancellationReasonNavigation)
                .HasForeignKey(pc => pc.CancellationReasonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
