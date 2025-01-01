using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the SatpReferredNoService entity.
    /// </summary>
    public class SatpReferredNoServiceConfiguration : IEntityTypeConfiguration<SatpReferredNoService>
    {
        public void Configure(EntityTypeBuilder<SatpReferredNoService> builder)
        {
            // Table name
            builder.ToTable("SatpReferredNoService");

            // Primary key
            builder.HasKey(e => e.SatpReferredNoServiceId);

            // Properties
            builder.Property(e => e.OfficeCode)
                .HasMaxLength(30);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            builder.Property(e => e.ReferralSource)
                .HasMaxLength(100);

            // Required fields
            builder.Property(e => e.RecordDate)
                .IsRequired();

            builder.Property(e => e.CreateDate)
                .IsRequired();

            builder.Property(e => e.UpdateDate)
                .IsRequired();

            builder.Property(e => e.NumReferred)
                .IsRequired();

            builder.Property(e => e.IsDeleted)
                .IsRequired();
        }
    }
}
