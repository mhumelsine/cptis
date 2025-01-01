using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the SatpComments entity.
    /// </summary>
    public class SatpCommentConfiguration : IEntityTypeConfiguration<SatpComment>
    {
        public void Configure(EntityTypeBuilder<SatpComment> builder)
        {
            // Table name
            builder.ToTable("SatpComment");

            // Primary key
            builder.HasKey(e => e.SatpCommentId);

            // Properties
            builder.Property(e => e.Comment)
                .HasMaxLength(1000)
                .IsRequired(false);
        }
    }
}
