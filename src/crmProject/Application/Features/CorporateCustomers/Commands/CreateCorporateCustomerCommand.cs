using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.CorporateCustomers.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Features.CorporateCustomers.Commands;

public class CreateCorporateCustomerCommand:IRequest<CreatedCorporateCustomerDto>
{
    public int CreatedById { get; set; }
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

    public class CreateCorporateCustomerCommandHandler:IRequestHandler<CreateCorporateCustomerCommand,CreatedCorporateCustomerDto>
    {
        private readonly ICorporateCustomerRepository _corporateCustomerRepository;
        private readonly IMapper _mapper;

        public CreateCorporateCustomerCommandHandler(ICorporateCustomerRepository corporateCustomerRepository, IMapper mapper)
        {
            _corporateCustomerRepository = corporateCustomerRepository;
            _mapper = mapper;
        }

        public async Task<CreatedCorporateCustomerDto> Handle(CreateCorporateCustomerCommand request, CancellationToken cancellationToken)
        {
            CorporateCustomer corporateCustomer = _mapper.Map<CorporateCustomer>(request);
            CorporateCustomer addedCorporateCustomer = await _corporateCustomerRepository.AddAsync(corporateCustomer);
            CreatedCorporateCustomerDto createdCorporateCustomerDto =
                _mapper.Map<CreatedCorporateCustomerDto>(addedCorporateCustomer);
            return createdCorporateCustomerDto;
        }
    }
        
}