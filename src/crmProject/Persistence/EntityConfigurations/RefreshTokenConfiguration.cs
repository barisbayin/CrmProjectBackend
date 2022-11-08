using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.ToTable("RefreshTokens");
            builder.HasKey(k => k.Id);
            builder.HasIndex(k => k.Token).IsUnique();

            builder.Property(p => p.UserId).HasColumnName("UserId");
            builder.Property(p => p.Token).HasColumnName("Token");
            builder.Property(p => p.Expires).HasColumnName("Expires");
            builder.Property(p => p.Created).HasColumnName("Created");
            builder.Property(p => p.CreatedByIp).HasColumnName("CreatedByIp").HasMaxLength(100);
            builder.Property(p => p.Revoked).HasColumnName("Revoked");
            builder.Property(p => p.RevokedByIp).HasColumnName("RevokedByIp").HasMaxLength(100);
            builder.Property(p => p.ReplacedByToken).HasColumnName("ReplacedByToken");
            builder.Property(p => p.ReasonRevoked).HasColumnName("ReasonRevoked").HasMaxLength(100);
        }
    }
}
