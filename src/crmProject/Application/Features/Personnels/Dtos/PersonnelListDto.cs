using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Personnels.Dtos
{
    public class PersonnelListDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string? FullAddress { get; set; }
        public string? AddressLine { get; set; }
        public int? CountryName { get; set; }
        public int? CityName { get; set; }
        public int? CountyName{ get; set; }
        public int? NeighbourhoodName{ get; set; }
        public string? ZipCode { get; set; }
        public string? GenderInformation { get; set; }
        public string? ImagePath { get; set; }
        public string DepartmentName { get; set; }
    }
}
