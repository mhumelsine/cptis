using Cptis.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace Cptis.EntityFramework.Configuration
{
    public class RegistrationMaltreatmentConfiguration : IEntityTypeConfiguration<RegistrationMaltreatment>
    {
        public void Configure(EntityTypeBuilder<RegistrationMaltreatment> builder)
        {
            builder.HasKey(x => x.RegistrationMaltreatmentId);
            builder.Audit(x => x.Audit);
        }
    }
}
