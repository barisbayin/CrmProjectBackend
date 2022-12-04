using Application.Features.Personnels.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Features.Personnels.Commands;

public class CreatePersonnelCommand : IRequest<CreatedPersonnelDto> // ISecuredRequest
{
    public int DepartmentId { get; set; }
    public int CreatedById { get; set; }
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


    //public string[] Roles { get; } 

    public class CreatePersonnelCommandHandler : IRequestHandler<CreatePersonnelCommand, CreatedPersonnelDto>
    {
        private readonly IPersonnelRepository _personnelRepository;
        private readonly IMapper _mapper;
        public CreatePersonnelCommandHandler(IPersonnelRepository personnelRepository, IMapper mapper)
        {
            _personnelRepository = personnelRepository;
            _mapper = mapper;
        }

        public async Task<CreatedPersonnelDto> Handle(CreatePersonnelCommand request, CancellationToken cancellationToken)
        {
            Personnel mappedPersonnel = _mapper.Map<Personnel>(request);
            Personnel createdPersonnel = await _personnelRepository.AddAsync(mappedPersonnel);
            CreatedPersonnelDto createdPersonnelDto = _mapper.Map<CreatedPersonnelDto>(createdPersonnel);
            return createdPersonnelDto;
        }
    }
}