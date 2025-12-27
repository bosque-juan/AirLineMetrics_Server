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
    internal class DocumentTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.HasKey(p => p.DocumentTypeId);

            builder.ToTable("DOCUMENT_TYPES");

            builder.Property(p => p.DocumentTypeId)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("DOCUMENT_TYPE_ID");

            builder.Property(p => p.DocumentTypeName)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("DESCRIPTION");

            builder.HasMany(dt => dt.PassengerNavigation)
                .WithOne(p => p.DocumentTypeNavigation)
                .HasForeignKey(p => p.DocumentTypeId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
