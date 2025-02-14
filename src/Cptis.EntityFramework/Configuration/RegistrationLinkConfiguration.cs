﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cptis.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cptis.EntityFramework.Configuration
{
    public class RegistrationLinkConfiguration : IEntityTypeConfiguration<RegistrationLink>
    {
        public void Configure(EntityTypeBuilder<RegistrationLink> builder)
        {
            builder.HasKey(x => x.RegistrationLinkId);
            builder.Audit(x => x.Audit);
        }
    }
}
