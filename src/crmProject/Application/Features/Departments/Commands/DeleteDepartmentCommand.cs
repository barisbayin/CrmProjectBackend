﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Departments.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Commands
{
    public class DeleteDepartmentCommand : IRequest<DeletedDepartmentDto>  /*,ISecuredRequest, ICacheRemoverRequest*/
    {
        public int Id { get; set; }
        public int RemovedById { get; set; }

        //public bool BypassCache { get; }
        //public string CacheKey => "brands-list";
        //public string[] Roles => new[] { Admin, BrandDelete };
        public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand, DeletedDepartmentDto>
        {
            private readonly IDepartmentRepository _departmentRepository;
            private readonly IMapper _mapper;

            public DeleteDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
            {
                _departmentRepository = departmentRepository;
                _mapper = mapper;
            }

            public async Task<DeletedDepartmentDto> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
            {
                DeletedDepartmentDto deletedDepartmentDto = new DeletedDepartmentDto();

                Department? departmentToBeDelete = await _departmentRepository.GetAsync(d => d.Id == request.Id, cancellationToken: cancellationToken);

                if (departmentToBeDelete == null) return deletedDepartmentDto;

                departmentToBeDelete.RemovedById = request.RemovedById;
                Department deletedDepartment = await _departmentRepository.MarkAsRemovedAsync(departmentToBeDelete);
                deletedDepartmentDto = _mapper.Map<DeletedDepartmentDto>(deletedDepartment);

                return deletedDepartmentDto;
            }
        }
    }
}