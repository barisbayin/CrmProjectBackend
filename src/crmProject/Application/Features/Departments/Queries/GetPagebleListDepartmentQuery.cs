using Application.Features.Departments.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Queries;

public class GetPagebleListDepartmentQuery : IRequest<DepartmentPagebleListModel>
{
    public PageRequest PageRequest { get; set; }

    public class GetPagebleListDepartmentQueryHandler : IRequestHandler<GetPagebleListDepartmentQuery, DepartmentPagebleListModel>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public GetPagebleListDepartmentQueryHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<DepartmentPagebleListModel> Handle(GetPagebleListDepartmentQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Department> departments = await _departmentRepository.GetPagebleListAsync(index: request.PageRequest.Page, 
                                                                                         size: request.PageRequest.PageSize,
                                                                                         cancellationToken: cancellationToken);
            DepartmentPagebleListModel mappedDepartmentPagebleListModel = _mapper.Map<DepartmentPagebleListModel>(departments);
            return mappedDepartmentPagebleListModel;
        }
    }

}