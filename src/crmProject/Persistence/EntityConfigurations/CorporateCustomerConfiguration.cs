using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
    {
        public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
        {
            builder.ToTable("CorporateCustomers");
            builder.HasKey(k => k.Id);
            builder.HasIndex(i => i.CustomerCode).IsUnique();
            builder.HasIndex(p => p.TaxNumber).IsUnique();
            builder.HasIndex(i => i.Email).IsUnique();

            builder.Property(p => p.CustomerCode).HasColumnName("CustomerCode").HasMaxLength(30);
            builder.Property(p => p.CompanyName).HasColumnName("CompanyName").HasMaxLength(100);
            builder.Property(p => p.CompanyEstablishmentDate).HasColumnName("CompanyEstablishmentDate").HasMaxLength(100);
            builder.Property(p => p.TaxNumber).HasColumnName("TaxNumber").HasMaxLength(15);
            builder.Property(p => p.TaxAdministration).HasColumnName("TaxAdministration").HasMaxLength(30);
            builder.Property(p => p.MainOperationCode).HasColumnName("MainOperationCode").HasMaxLength(15);
            builder.Property(p => p.MainOperationDescription).HasColumnName("MainOperationDescription").HasMaxLength(150);
            builder.Property(p => p.CompanyType).HasColumnName("CompanyType").HasMaxLength(100);
            builder.Property(p => p.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(15);
            builder.Property(p => p.Email).HasColumnName("Email").HasMaxLength(30);
            builder.Property(p => p.FullAddress).HasColumnName("FullAddress").HasMaxLength(200);
            builder.Property(p => p.AddressLine).HasColumnName("AddressLine").HasMaxLength(100);
            builder.Property(p => p.CountryId).HasColumnName("CountryId");
            builder.Property(p => p.CityId).HasColumnName("CityId");
            builder.Property(p => p.CountyId).HasColumnName("CountyId");
            builder.Property(p => p.ZipCode).HasColumnName("ZipCode").HasMaxLength(15);
            builder.Property(p => p.TaxPlatePath).HasColumnName("TaxPlatePath").HasMaxLength(300);

        }
    }
}
