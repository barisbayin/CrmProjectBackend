using Application.Features.Departments.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Commands;

public class RemoveDepartmentCommand : IRequest<RemovedDepartmentDto>  /*,ISecuredRequest, ICacheRemoverRequest*/
{
    public int Id { get; set; }
    public int RemovedById { get; set; }

    //public bool BypassCache { get; }
    //public string CacheKey => "brands-list";
    //public string[] Roles => new[] { Admin, BrandDelete };
    public class RemoveDepartmentCommandHandler : IRequestHandler<RemoveDepartmentCommand, RemovedDepartmentDto>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public RemoveDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<RemovedDepartmentDto> Handle(RemoveDepartmentCommand request, CancellationToken cancellationToken)
        {
            RemovedDepartmentDto removedDepartmentDto = new RemovedDepartmentDto();

            Department? departmentToBeRemove = await _departmentRepository.GetAsync(d => d.Id == request.Id, cancellationToken: cancellationToken);

            if (departmentToBeRemove == null) return removedDepartmentDto;

            departmentToBeRemove.RemovedById = request.RemovedById;
            Department removedDepartment = await _departmentRepository.MarkAsRemovedAsync(departmentToBeRemove);
            removedDepartmentDto = _mapper.Map<RemovedDepartmentDto>(removedDepartment);

            return removedDepartmentDto;
        }
    }
}