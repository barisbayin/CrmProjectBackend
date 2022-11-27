using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PersonnelConfiguration:IEntityTypeConfiguration<Personnel>
{
    public void Configure(EntityTypeBuilder<Personnel> builder)
    {
        builder.ToTable("Personnels");
        builder.HasKey(k => k.Id);
        builder.HasIndex(i => i.IdentityNumber).IsUnique();
        builder.HasIndex(i => i.Email).IsUnique();
            
        builder.Property(p => p.DepartmentId).HasColumnName("DepartmentId");
        builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(30);
        builder.Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(30);
        builder.Property(p => p.BirthDay).HasColumnName("BirthDay");
        builder.Property(p => p.IdentityNumber).HasColumnName("IdentityNumber").HasMaxLength(30);
        builder.Property(p => p.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(30);
        builder.Property(p => p.Email).HasColumnName("Email").HasMaxLength(30);
        builder.Property(p => p.FullAddress).HasColumnName("FullAddress").HasMaxLength(300);
        builder.Property(p => p.AddressLine).HasColumnName("AddressLine").HasMaxLength(300); ;
        builder.Property(p => p.CountryId).HasColumnName("CountryId");
        builder.Property(p => p.CityId).HasColumnName("CityId");
        builder.Property(p => p.CountyId).HasColumnName("CountyId");
        builder.Property(p => p.NeighbourhoodId).HasColumnName("NeighbourhoodId");
        builder.Property(p => p.ZipCode).HasColumnName("ZipCode").HasMaxLength(30);
        builder.Property(p => p.ImagePath).HasColumnName("ImagePath").HasMaxLength(300);

    }
}