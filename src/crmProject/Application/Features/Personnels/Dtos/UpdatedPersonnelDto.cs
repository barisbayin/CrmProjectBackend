using Domain.Enums;

namespace Application.Features.Personnels.Dtos;

public class UpdatedPersonnelDto
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }
    public string IdentityNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string FullAddress { get; set; }
    public string AddressLine { get; set; }
    public int CountryId { get; set; }
    public int CityId { get; set; }
    public int CountyId { get; set; }
    public int NeighbourhoodId { get; set; }
    public string ZipCode { get; set; }
    public GenderInformations GenderInformation { get; set; }
    public string? ImagePath { get; set; }
    public int CreatedById { get; set; }
    public DateTime CreationDate { get; set; }
    public int ModifiedById { get; set; }
    public DateTime ModifiedDate { get; set; }

}