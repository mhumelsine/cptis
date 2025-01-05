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
    public class IntakeAddendumClientConfiguration : IEntityTypeConfiguration<IntakeAddendumClient>
    {
        public void Configure(EntityTypeBuilder<IntakeAddendumClient> builder)
        {
            builder.ToTable("IntakeAddendumClient");

            builder.HasKey(e => e.IntakeAddendumClientId);

            builder.Property(e => e.UserFirstName).HasMaxLength(30);
            builder.Property(e => e.UserLastName).HasMaxLength(30);
            builder.Audit(x => x.Audit);
            builder.ComplexProperty(x => x.ClientId, options =>
            {
                options.Property(x => x.Value)
                    .HasColumnName("client_id")
                    .HasMaxLength(11);
            });

            builder.HasOne(e => e.IntakeAddendum)
                .WithMany()
                .HasForeignKey(e => e.IntakeAddendumId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.ClientDemographic)
                .WithMany()
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
