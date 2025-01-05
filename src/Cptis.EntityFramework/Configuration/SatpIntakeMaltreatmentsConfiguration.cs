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
    /// Configuration for the SatpIntakeMaltreatments entity.
    /// </summary>
    public class SatpIntakeMaltreatmentsConfiguration : IEntityTypeConfiguration<SatpIntakeMaltreatment>
    {
        public void Configure(EntityTypeBuilder<SatpIntakeMaltreatment> builder)
        {
            // Table name
            builder.ToTable("SatpIntakeMaltreatment");

            // Primary key
            builder.HasKey(e => e.SatpIntakeMaltreatmentId);

            // Properties
            builder.Property(e => e.AllegedMaltreatmentCode)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(e => e.TypeCode)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            builder.Property(e => e.CreateDate)
                .IsRequired();

            builder.Property(e => e.UpdateDate)
                .IsRequired();

            // Relationships
            builder.HasOne<SatpIntake>()
                .WithMany()
                .HasForeignKey(e => e.SatpIntakeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
