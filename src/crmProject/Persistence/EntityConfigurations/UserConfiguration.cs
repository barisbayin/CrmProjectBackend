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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(k => k.Id);
            builder.HasIndex(k => k.UserName).IsUnique();
            builder.HasIndex(i => i.Email).IsUnique();

            builder.Property(p => p.UserName).HasColumnName("UserName").HasMaxLength(30);
            builder.Property(p => p.FirstName).HasColumnName("FirstName").HasMaxLength(30);
            builder.Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(30);
            builder.Property(p => p.Email).HasColumnName("Email").HasMaxLength(100);
            builder.Property(p => p.PasswordHash).HasColumnName("PasswordHash");
            builder.Property(p => p.PasswordSalt).HasColumnName("PasswordSalt");
            builder.Property(p => p.AuthenticatorType).HasColumnName("AuthenticatorType").HasMaxLength(1);
            builder.Property(p => p.Status).HasColumnName("Status");
        }
    }
}
