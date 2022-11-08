using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Departments.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Commands.CreateDepartment
{
    public class CreateDepartmentCommand : IRequest<CreatedDepartmentDto>
    {
        public string DepartmentName { get; set; }
        public string Definition { get; set; }
        public int CreatedById { get; set; }

        public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, CreatedDepartmentDto>
        {
            private readonly IDepartmentRepository _departmentRepository;
            private readonly IMapper _mapper;

            public CreateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
            {
                _departmentRepository = departmentRepository;
                _mapper = mapper;
            }

            public async Task<CreatedDepartmentDto> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
            {
                Department mappedDepartment = _mapper.Map<Department>(request);
                Department createdDepartment = await _departmentRepository.AddAsync(mappedDepartment);
                CreatedDepartmentDto createdDepartmentDto = _mapper.Map<CreatedDepartmentDto>(createdDepartment);

                return createdDepartmentDto;
            }
        }
    }
}
