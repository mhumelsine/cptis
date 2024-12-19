using Microsoft.EntityFrameworkCore;

namespace Cptis.EntityFramework;

public class CptisReadContext : CptisWriteContext
{
    public CptisReadContext(DbContextOptions<CptisWriteContext> options)
        :base(options)
    {
        // disable to improve performance for readonly operations
        base.ChangeTracker.AutoDetectChangesEnabled = false;
        base.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
    
}