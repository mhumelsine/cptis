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
    public class IntakeServiceConfiguration : IEntityTypeConfiguration<IntakeService>
    {
        public void Configure(EntityTypeBuilder<IntakeService> builder)
        {
            builder.HasKey(x => x.IntakeServiceId);
            builder.Audit(x => x.Audit);
        }
    }
}
