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
    public class CaseProgressLinkedRegConfiguration : IEntityTypeConfiguration<CaseProgressLinkedReg>
    {
        public void Configure(EntityTypeBuilder<CaseProgressLinkedReg> builder)
        {
            builder.HasKey(e => e.CaseProgressLinkedRegId);
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
