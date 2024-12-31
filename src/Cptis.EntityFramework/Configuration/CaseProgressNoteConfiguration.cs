using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class CaseProgressNoteConfiguration : IEntityTypeConfiguration<CaseProgress>
    {
        public void Configure(EntityTypeBuilder<CaseProgress> builder)
        {
            builder.HasKey(e => e.CaseProgressId);
            builder.Audit(x => x.Audit);

            builder.ComplexProperty(x => x.ClientId, options =>
            {
                options.Property(x => x.Value)
                    .HasColumnName("client_id")
                    .HasMaxLength(11);
            });
        }
    }
}
p