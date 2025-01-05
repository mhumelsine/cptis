namespace Cptis.Core;

/// <summary>
/// Represents the audit information for a domain entity
/// </summary>
public class Audit
{
    /// <summary>
    /// The UserId of the user that created the entity
    /// </summary>
    public CptisUser CreatedBy { get; private set; }
    
    public string Page {  get; private set; }

    /// <summary>
    /// The date and time the entity was created
    /// </summary>
    public DateTime CreatedOn { get; private set; }
    
    /// <summary>
    /// The UserId of the last user to modify the entity.
    /// If no changes have been made, this will match <paramref name="CreatedBy" />.
    /// </summary>
    public CptisUser ModifiedBy { get; private set; }
    
    /// <summary>
    /// The date and time the entity was last modified.
    /// If no changes have been made, this will match <paramref name="CreatedOn" />.
    /// </summary>
    public DateTime ModifiedOn  { get; private set; }

    /// <summary>
    /// Creates a new audit with CreatedBy and ModifiedBy as UserId.None and CreatedOn and ModifiedOn as DateTime.MinValue.
    /// </summary>
    public Audit()
    {
        //ModifiedBy = CreatedBy = UserId.None;
        ModifiedOn = CreatedOn = DateTime.MinValue;
    }
    
    /// <summary>
    /// Creates an audit from existing values.
    /// </summary>
    /// <param name="createdBy">The UserId that created the entity</param>
    /// <param name="createdOn">The date and time the entity was created</param>
    /// <param name="modifiedBy">The UserId that last modified the entity</param>
    /// <param name="modifiedOn">The date and time the entity was last modified</param>
    private Audit(CptisUser createdBy, DateTime createdOn, CptisUser modifiedBy, DateTime modifiedOn)
    {
        CreatedBy = createdBy;
        CreatedOn = createdOn;
        ModifiedBy = modifiedBy;
        ModifiedOn = modifiedOn;
    }

    /// <summary>
    /// Marks the audit as modified by a specific user and the current time.
    /// </summary>
    /// <param name="userId">The UserId of the user or process that modified the entity</param>
    /// <param name="modifiedOn">Optional: the date and time the entity was modified</param>
    public void Modified(CptisUser userId, DateTime modifiedOn = default)
    {
        ModifiedBy = userId;
        ModifiedOn = modifiedOn == default ? DateTime.Now : modifiedOn;
    }
    
    /// <summary>
    /// Marks the audit as created by a specific user and the current time.
    /// </summary>
    /// <param name="userId">The UserId of the user or process that created the entity</param>
    /// <param name="createdOn">Optional: the date and time the entity was created</param>
    public void Created(CptisUser userId, DateTime createdOn = default)
    {
        CreatedBy = userId;
        CreatedOn = createdOn == default ? DateTime.Now : createdOn;
        
        // Always mark the modified timestamp so we have a single field to track change over time
        Modified(CreatedBy, CreatedOn);
    }
}