using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.ToTable("Provider");

            builder.HasKey(e => e.ProviderId);

            builder.Property(e => e.ProviderCode).HasMaxLength(5);
            builder.Property(e => e.ProviderFirstName).HasMaxLength(30);
            builder.Property(e => e.ProviderLastName).HasMaxLength(30);
            builder.Property(e => e.ProviderAddress).HasMaxLength(100);
            builder.Property(e => e.ProviderAddress2).HasMaxLength(30);
            builder.Property(e => e.ProviderCity).HasMaxLength(30);
            builder.Property(e => e.ProviderState).HasMaxLength(11);
            builder.Property(e => e.ProviderZip).HasMaxLength(10);
            builder.Property(e => e.ProviderCounty).HasMaxLength(2);
            builder.Phone(x => x.ProviderPhone);
            builder.Property(e => e.ProviderType).HasMaxLength(30);
            builder.Property(e => e.CptOffice).HasMaxLength(30);
            builder.Property(e => e.Active).HasMaxLength(30);
            builder.Property(e => e.UserFirstName).HasMaxLength(30);
            builder.Property(e => e.UserLastName).HasMaxLength(30);
            builder.Property(e => e.License).HasMaxLength(30);
            builder.Property(e => e.EmploymentStatus).HasMaxLength(30);
            builder.Property(e => e.EmploymentStatusDescription).HasMaxLength(30);
            builder.Property(e => e.ProviderTitle).HasMaxLength(30);
            builder.Property(e => e.ApprovedStaff).HasMaxLength(30);
            builder.Audit(x => x.Audit);

            builder.HasOne(e => e.SecurityUser)
                .WithMany()
                .HasForeignKey(e => e.SecurityId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
