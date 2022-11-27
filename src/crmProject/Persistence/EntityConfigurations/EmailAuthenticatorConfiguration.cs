using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class EmailAuthenticatorConfiguration:IEntityTypeConfiguration<EmailAuthenticator>
{
    public void Configure(EntityTypeBuilder<EmailAuthenticator> builder)
    {
        builder.ToTable("EmailAuthenticators");
        builder.HasKey(k => k.Id);
            
        builder.Property(p => p.UserId).HasColumnName("UserId");
        builder.Property(p => p.ActivationKey).HasColumnName("ActivationKey");
        builder.Property(p => p.IsVerified).HasColumnName("Expires");
    }
}