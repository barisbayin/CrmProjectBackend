using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.CorporateCustomers.Commands;
using Application.Features.CorporateCustomers.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.CorporateCustomers.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CorporateCustomer, CreateCorporateCustomerCommand>().ReverseMap();
        CreateMap<CorporateCustomer, CreatedCorporateCustomerDto>().ReverseMap();
    }
}