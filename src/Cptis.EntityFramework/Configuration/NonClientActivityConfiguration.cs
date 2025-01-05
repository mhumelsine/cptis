using Cptis.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the NonClientActivity entity.
    /// </summary>
    public class NonClientActivityConfiguration : IEntityTypeConfiguration<NonClientActivity>
    {
        public void Configure(EntityTypeBuilder<NonClientActivity> builder)
        {
            // Table name
            builder.ToTable("NonClientActivity");

            // Primary key
            builder.HasKey(e => e.NonClientActivityId);

            // Properties
            builder.Property(e => e.NcProvider)
                .HasMaxLength(100);

            builder.Property(e => e.NcActivitiy)
                .HasMaxLength(255);

            builder.Property(e => e.CptOffice)
                .HasMaxLength(50);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(50);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(50);

            builder.Property(e => e.CE)
                .HasMaxLength(50);

            builder.Property(e => e.Hours)
                .HasMaxLength(50);

            builder.Property(e => e.TypeActivity)
                .HasMaxLength(100);

            builder.Property(e => e.Audience)
                .HasMaxLength(100);

            // Relationships
            builder.HasOne(e => e.Provider)
                .WithMany()
                .HasForeignKey(e => e.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
