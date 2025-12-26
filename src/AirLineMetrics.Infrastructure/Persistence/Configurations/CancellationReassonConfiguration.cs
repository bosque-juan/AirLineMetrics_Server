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
    internal class CancellationReassonConfiguration : IEntityTypeConfiguration<CancellationReasson>
    {
        public void Configure(EntityTypeBuilder<CancellationReasson> builder)
        {
            builder.HasKey(cr => cr.CancellationReassonId);

            builder.ToTable("CANCELLATION_REASSONS");

            builder.Property(cr => cr.CancellationReassonId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd()
                .HasColumnName("CANCELLATION_REASSON_ID");

            builder.Property(cr => cr.Description)
                .HasMaxLength(100)
                .HasColumnName("Description");
        }
    }

}
