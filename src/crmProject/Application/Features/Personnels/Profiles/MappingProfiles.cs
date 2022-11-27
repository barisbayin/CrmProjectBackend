using Application.Features.Personnels.Commands;
using Application.Features.Personnels.Dtos;
using Application.Features.Personnels.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Personnels.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Personnel, CreatedPersonnelDto>().ReverseMap();
        CreateMap<Personnel, UpdatedPersonnelDto>().ReverseMap();
        CreateMap<Personnel, RemovedPersonnelDto>().ReverseMap();

        CreateMap<Personnel, CreatePersonnelCommand>().ReverseMap();
        CreateMap<Personnel, UpdatePersonnelCommand>().ReverseMap();
        CreateMap<Personnel, RemovePersonnelCommand>().ReverseMap();

        CreateMap<IPaginate<Personnel>, PersonnelListModel>().ReverseMap();
        CreateMap<Personnel, PersonnelListDto>().ForMember(p=> p.DepartmentName,opt=> opt.MapFrom(d=>d.Department.DepartmentName))
            .ForMember(p=> p.GenderInformation, opt => opt.MapFrom(g => g.GenderInformation!.Value))
            .ReverseMap();
    }
}