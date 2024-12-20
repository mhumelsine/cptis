using System.Linq.Expressions;
using Cptis.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cptis.EntityFramework.Configuration;

public static class Extensions
{
    /// <summary>
    /// Adds Audit as a complex type
    /// </summary>
    /// <param name="builder">The builder</param>
    /// <param name="auditSelector">The audit selector</param>
    /// <typeparam name="T">The type of object that has the Audit</typeparam>
    /// <typeparam name="TAudit">The Audit property</typeparam>
    public static void Audit<T, TAudit>(this EntityTypeBuilder<T> builder, Expression<Func<T, TAudit?>> auditSelector)
        where T : class
        where TAudit : Audit
    {
        builder.ComplexProperty(auditSelector, options =>
        {
            options.Property(x => x.CreatedOn)
                .HasColumnName("audit_created_on");
            
            options.ComplexProperty(x => x.CreatedBy, createdOptions =>
            {
                createdOptions.Property(x => x.Value)
                    .HasColumnName("audit_created_by");
            });

            options.Property(x => x.ModifiedOn)
                .HasColumnName("audit_modified_on");
            
            options.ComplexProperty(x => x.ModifiedBy, createdOptions =>
            {
                createdOptions.Property(x => x.Value)
                    .HasColumnName("audit_modified_by");
            });
        });
    }
    
    
    /// <summary>
    /// Adds Address as a complex type
    /// </summary>
    /// <param name="builder">The builder</param>
    /// <param name="selector">The selector</param>
    /// <typeparam name="T">The type of object that has the Address</typeparam>
    /// <typeparam name="TAddress">The Address property</typeparam>
    public static void Address<T, TAddress>(this EntityTypeBuilder<T> builder, Expression<Func<T, TAddress?>> selector)
        where T : class
        where TAddress : Address
    {
        builder.ComplexProperty(selector, options =>
        {
            options.ComplexProperty(x => x.State, stateOptions =>
            {
                stateOptions.Property(x => x.Code)
                    .HasMaxLength(2)
                    .HasColumnType("char");
                
                stateOptions.Ignore(x => x.Name);
            });

            options.ComplexProperty(x => x.Zip, zipOptions =>
            {
                zipOptions.Property(x => x.Code)
                    .HasMaxLength(5);
                
                zipOptions.Property(x => x.Plus4)
                    .HasMaxLength(4);
                
                zipOptions.Ignore(x => x.Value);
            });
        });
    }

    public static void Phone<T, TPhone>(this EntityTypeBuilder<T> builder, Expression<Func<T, TPhone?>> selector)
        where T : class
        where TPhone : PhoneNumber
    {
        builder.ComplexProperty(selector, options =>
        {
            options.Property(x => x.AreaCode)
                .HasMaxLength(3)
                .HasColumnType("char");
            
            options.Property(x => x.Number)
                .HasMaxLength(7)
                .HasColumnType("char");
            
            options.Property(x => x.Extension)
                .HasMaxLength(30);
        });
    }

}