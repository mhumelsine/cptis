namespace Cptis.Core;

public class Audit
{
    public UserId CreatedBy { get; private set; }
    public DateTime CreatedOn { get; private set; }
    public UserId ModifiedBy { get; private set; }
    public DateTime ModifiedOn  { get; private set; }

    public Audit()
    {
        ModifiedBy = CreatedBy = UserId.None;
        ModifiedOn = CreatedOn = DateTime.MinValue;
    }
    
    public Audit(UserId createdBy, DateTime createdOn, UserId modifiedBy, DateTime modifiedOn)
    {
        CreatedBy = createdBy;
        CreatedOn = createdOn;
        ModifiedBy = modifiedBy;
        ModifiedOn = modifiedOn;
    }

    public void Modified(UserId userId)
    {
        ModifiedBy = userId;
        ModifiedOn = DateTime.Now;
    }
    
    public void Created(UserId userId)
    {
        CreatedBy = userId;
        CreatedOn = DateTime.Now;
        
        Modified(userId);
    }
}