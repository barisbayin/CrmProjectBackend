using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperationClaims");
        builder.HasKey(k => k.Id);
        builder.HasIndex(k => k.Name).IsUnique();
        builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(100);
    }
}