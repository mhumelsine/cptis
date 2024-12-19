using Cptis.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cptis.EntityFramework.Configuration;

public class ClientAddressConfiguration : IEntityTypeConfiguration<ClientAddress>
{
    public void Configure(EntityTypeBuilder<ClientAddress> builder)
    {
        builder.HasKey(x => x.ClientAddressKey);
        builder.Audit(x => x.Audit);
        builder.Address(x => x.Address);
    }
}