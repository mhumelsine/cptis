using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cptis.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the SatpMonthlyDataAttestation entity.
    /// </summary>
    public class SatpMonthlyDataAttestationConfiguration : IEntityTypeConfiguration<SatpMonthlyDataAttestation>
    {
        public void Configure(EntityTypeBuilder<SatpMonthlyDataAttestation> builder)
        {
            // Table name
            builder.ToTable("SatpMonthlyDataAttestation");

            // Primary key
            builder.HasKey(e => e.SatpMonthlyDataAttestationId);

            // Properties
            builder.Property(e => e.OfficeCode)
                .HasMaxLength(30);

            builder.Property(e => e.ProgramCoordinator)
                .HasMaxLength(100);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            builder.Property(e => e.RecordDate)
                .IsRequired();

            builder.Property(e => e.CreateDate)
                .IsRequired();

            builder.Property(e => e.UpdateDate)
                .IsRequired();

            builder.Property(e => e.IsDeleted)
                .IsRequired();
        }
    }

}
