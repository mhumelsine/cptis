using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the SatpProvider entity.
    /// </summary>
    public class SatpProviderConfiguration : IEntityTypeConfiguration<SatpProvider>
    {
        public void Configure(EntityTypeBuilder<SatpProvider> builder)
        {
            // Table name
            builder.ToTable("SatpProvider");

            // Primary key
            builder.HasKey(e => e.SatpProviderId);

            // Properties
            builder.Property(e => e.FirstName)
                .HasMaxLength(50);

            builder.Property(e => e.LastName)
                .HasMaxLength(50);

            builder.Property(e => e.Address)
                .HasMaxLength(100);

            builder.Property(e => e.Address1)
                .HasMaxLength(100);

            builder.Property(e => e.City)
                .HasMaxLength(50);

            builder.Property(e => e.State)
                .HasMaxLength(30);

            builder.Property(e => e.Zip)
                .HasMaxLength(20);

            builder.Property(e => e.Phone)
                .HasMaxLength(30);

            builder.Property(e => e.AltPhone)
                .HasMaxLength(30);

            builder.Property(e => e.CountyCode)
                .HasMaxLength(30);

            builder.Property(e => e.OfficeCode)
                .HasMaxLength(30);

            builder.Property(e => e.ProviderTypeCode)
                .HasMaxLength(30);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            builder.Property(e => e.EmploymentStatus)
                .HasMaxLength(50);

            builder.Property(e => e.EmploymentStatusDescription)
                .HasMaxLength(100);

            builder.Property(e => e.ProviderTitle)
                .HasMaxLength(50);

            // Required fields
            builder.Property(e => e.CreateDate)
                .IsRequired();

            builder.Property(e => e.UpdateDate)
                .IsRequired();

            builder.Property(e => e.Active)
                .IsRequired();
        }
    }
}
