using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.IndividualCustomer.Dtos;

public class UpdatedIndividualCustomerDto
{
    public int Id { get; set; }
    public string CustomerCode { get; set; }
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
    public GenderInformation? GenderInformation { get; set; }
    public string? ImagePath { get; set; }
    public int CreatedById { get; set; }
    public DateTime CreationDate { get; set; }
    public int ModifiedById { get; set; }
    public DateTime ModifiedDate { get; set; }
}