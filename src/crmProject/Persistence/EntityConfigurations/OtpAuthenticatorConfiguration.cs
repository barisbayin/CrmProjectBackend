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
    public class OtpAuthenticatorConfiguration : IEntityTypeConfiguration<OtpAuthenticator>
    {
        public void Configure(EntityTypeBuilder<OtpAuthenticator> builder)
        {
            builder.ToTable("OtpAuthenticators");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.UserId).HasColumnName("UserId");
            builder.Property(p => p.SecretKey).HasColumnName("ActivationKey");
            builder.Property(p => p.IsVerified).HasColumnName("Expires");
        }
    }
}
