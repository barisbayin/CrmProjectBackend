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
using MediatR;

namespace Application.Features.Departments.Commands
{
    public class UpdateDepartmentCommand : IRequest<UpdatedDepartmentDto>
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Definition { get; set; }
        public int ModifiedById { get; set; }

        public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand, UpdatedDepartmentDto>
        {
            private readonly IDepartmentRepository _departmentRepository;
            private readonly IMapper _mapper;

            public UpdateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
            {
                _departmentRepository = departmentRepository;
                _mapper = mapper;
            }

            public async Task<UpdatedDepartmentDto> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
            {
                UpdatedDepartmentDto updatedDepartmentDto = new UpdatedDepartmentDto();

                Department? departmentToBeUpdate = await _departmentRepository.GetAsync(d => d.Id == request.Id, cancellationToken: cancellationToken);

                if (departmentToBeUpdate == null) return updatedDepartmentDto;

                departmentToBeUpdate.DepartmentName = request.DepartmentName;
                departmentToBeUpdate.Definition = request.Definition;
                departmentToBeUpdate.ModifiedById = request.ModifiedById;

                Department updatedDepartment = await _departmentRepository.UpdateAsync(departmentToBeUpdate);
                updatedDepartmentDto = _mapper.Map<UpdatedDepartmentDto>(updatedDepartment);

                return updatedDepartmentDto;

            }
        }
    }
}
