using Cptis.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cptis.EntityFramework.Configuration;

public class ClientPhoneConfiguration : IEntityTypeConfiguration<ClientPhone>
{
    public void Configure(EntityTypeBuilder<ClientPhone> builder)
    {
        builder.HasKey(x => x.ClientPhoneKey);
        builder.Audit(x => x.Audit);
        builder.Phone(x => x.Phone);
    }
}