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
    internal class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.HasKey(p => p.PromotionId);

            builder.ToTable("PROMOTIONS");

            builder.Property(p => p.PromotionId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd()
                .HasColumnName("PROMOTION_ID");

            builder.Property(p => p.Description)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPTION");

            builder.Property(p => p.PromotionStart)
                .HasColumnName("START");

            builder.Property(p => p.PromotionEnd)
                .HasColumnName("END");

            builder.Property(p => p.PromotionDiscount)
                .HasColumnName("PROMOTION_DISCOUNT");

            builder.HasMany(p => p.FlightPromotionsNavigation)
                .WithOne(fp => fp.PromotionNavigation)
                .HasForeignKey(p => p.PromotionId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
