using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Departments.Commands.CreateDepartment;
using Application.Features.Departments.Commands.DeleteDepartment;
using Application.Features.Departments.Commands.UpdateDepartment;
using Application.Features.Departments.Dtos;
using Application.Features.Personnels.Commands.CreatePersonnel;
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
            CreateMap<Department, DeletedDepartmentDto>().ReverseMap();
            CreateMap<Department, DeleteDepartmentCommand>().ReverseMap();
        }
    }
}
