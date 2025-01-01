using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class CodeConfiguration : IEntityTypeConfiguration<Code>
    {
        public void Configure(EntityTypeBuilder<Code> builder)
        {
            builder.ToTable("Code");

            builder.HasKey(e => e.CodeId);
            builder.Audit(x => x.Audit);

            builder.Property(e => e.CodeType).HasMaxLength(30);
            builder.Property(e => e.CodeName).HasMaxLength(30);
            builder.Property(e => e.CodeDescription).HasMaxLength(30);
            builder.Property(e => e.CodeActive).HasMaxLength(30);
        }
    }
}
