using Cptis.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cptis.EntityFramework.Configuration;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(x => x.ClientKey);
        
        builder.Audit(x => x.Audit);
        
        builder.ComplexProperty(x => x.ClientId, options =>
        {
            options.Property(x => x.Value)
                .HasColumnName("client_id")
                .HasMaxLength(30);
        });

        builder.ComplexProperty(x => x.Name);
        
        builder.ComplexProperty(x => x.BirthDate, options =>
        {
            options.Property(x => x.Date)
                .HasColumnType("Date");
        });
        
        builder.Property(x => x.DeathDate)
            .HasColumnType("Date");
        
        builder.Address(x => x.Address);

        builder.HasMany(x => x.PreviousAddresses)
            .WithOne();
    }
}