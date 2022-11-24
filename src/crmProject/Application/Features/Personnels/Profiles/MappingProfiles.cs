using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Personnels.Commands;
using Application.Features.Personnels.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Personnels.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Personnel, CreatedPersonnelDto>().ReverseMap();
            CreateMap<Personnel, CreatePersonnelCommand>().ReverseMap();
            CreateMap<Personnel, UpdatedPersonnelDto>().ReverseMap();
            CreateMap<Personnel, UpdatePersonnelCommand>().ReverseMap();
            CreateMap<Personnel, DeletedPersonnelDto>().ReverseMap();
            CreateMap<Personnel, DeletePersonnelCommand>().ReverseMap();
        }
    }
}
