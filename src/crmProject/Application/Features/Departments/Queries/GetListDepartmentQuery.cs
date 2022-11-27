using Application.Features.Departments.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Queries;

public class GetListDepartmentQuery : IRequest<DepartmentListModel>
{
    public PageRequest PageRequest { get; set; }

    public class GetListDepartmentQueryHandler : IRequestHandler<GetListDepartmentQuery, DepartmentListModel>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public GetListDepartmentQueryHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<DepartmentListModel> Handle(GetListDepartmentQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Department> departments = await _departmentRepository.GetListAsync(index: request.PageRequest.Page, 
                                                                                         size: request.PageRequest.PageSize,
                                                                                         cancellationToken: cancellationToken);
            DepartmentListModel mappedDepartmentListModel = _mapper.Map<DepartmentListModel>(departments);
            return mappedDepartmentListModel;
        }
    }

}