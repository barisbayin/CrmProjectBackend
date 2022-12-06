using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CorporateCustomers.Dtos;

public class UpdatedCorporateCustomerDto
{
    public int Id { get; set; }
    public string CustomerCode { get; set; }
    public string CompanyName { get; set; }
    public DateTime CompanyEstablishmentDate { get; set; }
    public string TaxNumber { get; set; }
    public string TaxAdministration { get; set; }
    public string MainOperationCode { get; set; }
    public string MainOperationDescription { get; set; }
    public CompanyType CompanyType { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string? FullAddress { get; set; }
    public string? AddressLine { get; set; }
    public int? CountryId { get; set; }
    public int? CityId { get; set; }
    public int? CountyId { get; set; }
    public int? NeighbourhoodId { get; set; }
    public string? ZipCode { get; set; }
    public string? TaxPlatePath { get; set; }
    public int CreatedById { get; set; }
    public DateTime CreationDate { get; set; }
    public int ModifiedById { get; set; }
    public DateTime ModifiedDate { get; set; }
}