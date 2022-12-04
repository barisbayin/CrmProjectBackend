using Core.Persistence.Repositories;
using Domain.Enums;

namespace Domain.Entities;

public class Personnel : Entity
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }
    public string IdentityNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string? FullAddress { get; set; } 
    public string? AddressLine { get; set; }
    public int? CountryId { get; set; }
    public int? CityId { get; set; } 
    public int? CountyId { get; set; } 
    public int? NeighbourhoodId { get; set; } 
    public string? ZipCode { get; set; }
    public GenderInformations? GenderInformation { get; set; } 
    public string? ImagePath { get; set; }
    public virtual Department Department { get; set; }


    public Personnel()
    {
                
    }

    public Personnel(int id, string name, string lastName, DateTime birthDay, string identityNumber, string phoneNumber, string email, string? fullAddress, string? addressLine, int? countryId, int? cityId, int? countyId, int? neighbourhoodId, string? zipCode, GenderInformations? genderInformation, string? imagePath, int departmentId) : base(id)
    {
        DepartmentId = departmentId;
        Name = name;
        LastName = lastName;
        BirthDay = birthDay;
        IdentityNumber = identityNumber;
        PhoneNumber = phoneNumber;
        Email = email;
        FullAddress = fullAddress;
        AddressLine = addressLine;
        CountryId = countryId;
        CityId = cityId;
        CountyId = countyId;
        NeighbourhoodId = neighbourhoodId;
        ZipCode = zipCode;
        GenderInformation = genderInformation;
        ImagePath = imagePath;
    }
}