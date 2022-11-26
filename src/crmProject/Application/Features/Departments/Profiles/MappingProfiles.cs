using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Departments.Commands;
using Application.Features.Departments.Dtos;
using Application.Features.Personnels.Commands;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Departments.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Department, CreatedDepartmentDto>().ReverseMap();
            CreateMap<Department, CreateDepartmentCommand>().ReverseMap();
            CreateMap<Department, UpdatedDepartmentDto>().ReverseMap();
            CreateMap<Department, UpdateDepartmentCommand>().ReverseMap();
            CreateMap<Department, RemovedDepartmentDto>().ReverseMap();
            CreateMap<Department, RemoveDepartmentCommand>().ReverseMap();
        }
    }
}
