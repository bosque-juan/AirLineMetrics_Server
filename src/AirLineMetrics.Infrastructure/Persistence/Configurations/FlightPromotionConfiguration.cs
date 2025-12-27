using AirLineMetrics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Infrastructure.Persistence.Configurations
{
    internal class FlightPromotionConfiguration : IEntityTypeConfiguration<FlightPromotion>
    {
        public void Configure(EntityTypeBuilder<FlightPromotion> builder)
        {
            builder.HasKey(fp => fp.FlightPromotionId);

            builder.ToTable("FLIGHTS_PROMOTIONS");

            builder.Property(fp => fp.FlightPromotionId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd()
                .HasColumnName("FLIGHT_PROMOTION_ID");

            builder.Property(fp => fp.PromotionId)
              .UseIdentityColumn()
              .ValueGeneratedOnAdd()
              .HasColumnName("PROMOTION_ID");

            builder.Property(fp => fp.FlightId)
             .UseIdentityColumn()
             .ValueGeneratedOnAdd()
             .HasColumnName("FLIGHT_ID");

            builder.HasOne(fp => fp.PromotionNavigation).WithMany(p => p.FlightPromotionsNavigation)
                    .HasForeignKey(fp => fp.PromotionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FLIGHT_PROMOTIONS_PROMOTIONS");


            builder.HasOne(fp => fp.FlightNavigation).WithMany(f => f.FlightPromotionsNavigation)
                    .HasForeignKey(fp => fp.FlightId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FLIGHTS_PROMOTIONS_FLIGHTS");
        }
    }
}
