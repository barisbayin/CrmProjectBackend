using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Personnels.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Features.Personnels.Commands;

public class UpdatePersonnelCommand : IRequest<UpdatedPersonnelDto>
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
    public GenderInformation GenderInformation { get; set; }
    public string? ImagePath { get; set; }
    public int ModifiedById { get; set; }


    public class UpdatePersonnelCommandHandler : IRequestHandler<UpdatePersonnelCommand, UpdatedPersonnelDto>
    {
        private readonly IPersonnelRepository _personnelRepository;
        private readonly IMapper _mapper;

        public UpdatePersonnelCommandHandler(IPersonnelRepository personnelRepository, IMapper mapper)
        {
            _personnelRepository = personnelRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedPersonnelDto> Handle(UpdatePersonnelCommand request, CancellationToken cancellationToken)
        {
            Personnel mappedPersonnel = _mapper.Map<Personnel>(request);
            Personnel updatedPersonnel = await _personnelRepository.UpdateAsync(mappedPersonnel);
            UpdatedPersonnelDto updatedPersonnelDto = _mapper.Map<UpdatedPersonnelDto>(updatedPersonnel);

            return updatedPersonnelDto;
        }
    }

}