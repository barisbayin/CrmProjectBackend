using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Departments.Dtos;
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
            UpdatedPersonnelDto updatedPersonnelDto = new UpdatedPersonnelDto();

            Personnel? personnelToBeUpdate = await _personnelRepository.GetAsync(p => p.Id == request.Id, cancellationToken: cancellationToken);

            if (personnelToBeUpdate == null) return updatedPersonnelDto;

            personnelToBeUpdate.DepartmentId = request.DepartmentId;
            personnelToBeUpdate.Name = request.Name;
            personnelToBeUpdate.LastName = request.LastName;
            personnelToBeUpdate.BirthDay = request.BirthDay;
            personnelToBeUpdate.IdentityNumber = request.IdentityNumber;
            personnelToBeUpdate.PhoneNumber = request.PhoneNumber;
            personnelToBeUpdate.Email = request.Email;
            personnelToBeUpdate.FullAddress = request.FullAddress;
            personnelToBeUpdate.AddressLine = request.AddressLine;
            personnelToBeUpdate.CountryId = request.CountryId;
            personnelToBeUpdate.CityId = request.CityId;
            personnelToBeUpdate.CountyId = request.CountyId;
            personnelToBeUpdate.NeighbourhoodId = request.NeighbourhoodId;
            personnelToBeUpdate.ZipCode = request.ZipCode;
            personnelToBeUpdate.GenderInformation = request.GenderInformation;
            personnelToBeUpdate.ImagePath = request.ImagePath;
            personnelToBeUpdate.ModifiedById = request.ModifiedById;

            Personnel updatedPersonnel = await _personnelRepository.UpdateAsync(personnelToBeUpdate);
            updatedPersonnelDto = _mapper.Map<UpdatedPersonnelDto>(updatedPersonnel);

            return updatedPersonnelDto;
        }
    }

}