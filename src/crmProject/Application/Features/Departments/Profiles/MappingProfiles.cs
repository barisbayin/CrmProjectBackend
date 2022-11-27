using Application.Features.Departments.Commands;
using Application.Features.Departments.Dtos;
using Application.Features.Departments.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Departments.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Department, CreatedDepartmentDto>().ReverseMap();
        CreateMap<Department, UpdatedDepartmentDto>().ReverseMap();
        CreateMap<Department, RemovedDepartmentDto>().ReverseMap();
        CreateMap<Department, DepartmentListDto>().ReverseMap();

        CreateMap<Department, CreateDepartmentCommand>().ReverseMap();
        CreateMap<Department, UpdateDepartmentCommand>().ReverseMap();
        CreateMap<Department, RemoveDepartmentCommand>().ReverseMap();

        CreateMap<IPaginate<Department>, DepartmentListModel>().ReverseMap();
        
    }
}