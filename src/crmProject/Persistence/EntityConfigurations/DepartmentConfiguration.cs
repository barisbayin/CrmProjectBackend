using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class DepartmentConfiguration:IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("Departments");
        builder.HasKey(k => k.Id);
        builder.HasIndex(i => i.DepartmentName).IsUnique();
            
        builder.Property(p => p.DepartmentName).HasColumnName("DepartmentName").HasMaxLength(30);
        builder.Property(p => p.Definition).HasColumnName("Definition").HasMaxLength(200);
    }   
}