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
    public class IntakeAddendumConfiguration : IEntityTypeConfiguration<IntakeAddendum>
    {
        public void Configure(EntityTypeBuilder<IntakeAddendum> builder)
        {
            builder.ToTable("IntakeAddendum");

            builder.HasKey(e => e.IntakeAddendumId);

            builder.Property(e => e.IntakeAddendumSequenceNumber).HasMaxLength(5);
            builder.Property(e => e.Addendum).HasMaxLength(30);
            builder.Property(e => e.CoordinatorCompletingAddendum).HasMaxLength(5);
            builder.Property(e => e.ClosureCode).HasMaxLength(5);
            builder.Property(e => e.CreatedBy).HasMaxLength(5);
            builder.Audit(x => x.Audit);

            builder.HasOne(e => e.Intake)
                .WithMany(i => i.IntakeAddendums)
                .HasForeignKey(e => e.IntakeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
