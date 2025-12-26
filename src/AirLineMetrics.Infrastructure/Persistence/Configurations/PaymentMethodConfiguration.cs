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
    internal class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(pm => pm.PaymentMethodId);

            builder.ToTable("PAYMENT_METHODS");

            builder.Property(pm => pm.PaymentMethodId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("PAYMENT_METHOD_ID");

            builder.Property(pm => pm.PaymentMethodName)
                .IsRequired()
                .HasColumnName("NAME");
        }
    }
}
