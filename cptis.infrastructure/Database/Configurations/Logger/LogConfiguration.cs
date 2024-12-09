using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using cptis.domain.Logger;

namespace cptis.infrastructure.Database.Configurations
{
    public class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.ToTable("Log");

            builder.HasKey(c => c.Id);
            builder.Property(e => e.Timestamp).IsRequired();
            builder.Property(e => e.Level).IsRequired();
            builder.Property(e => e.Message).IsRequired();
            builder.Property(e => e.Source).IsRequired();
            builder.Property(e => e.ClassName).IsRequired(false);
            builder.Property(e => e.Method).IsRequired(false);
            builder.Property(e => e.Exception).IsRequired(false);
            builder.Property(e => e.InnerException).IsRequired(false);
            builder.Property(e => e.ExceptionType).IsRequired(false);
            builder.Property(e => e.Stacktrace).IsRequired(false);
            builder.Property(e => e.Process).IsRequired();
            builder.Property(e => e.User).IsRequired();
        }
    }
}
