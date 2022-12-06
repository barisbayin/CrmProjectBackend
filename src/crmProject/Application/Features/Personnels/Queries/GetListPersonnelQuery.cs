using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Personnels.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Personnels.Queries;

public class GetListPersonnelQuery :IRequest<PersonnelListModel>
{
    public PageRequest PageRequest { get; set; }

    public class GetListPersonnelQueryHandler : IRequestHandler<GetListPersonnelQuery,PersonnelListModel>
    {
        private readonly IPersonnelRepository _personnelRepository;
        private readonly IMapper _mapper;

        public GetListPersonnelQueryHandler(IPersonnelRepository personnelRepository, IMapper mapper)
        {
            _personnelRepository = personnelRepository;
            _mapper = mapper;
        }

        public async Task<PersonnelListModel> Handle(GetListPersonnelQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Personnel> personnels = await _personnelRepository.GetPagebleListAsync(include: p =>
                    p.Include(r => r.Department),
                index: request.PageRequest.Page,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken);
            PersonnelListModel mappedPersonnelListModel = _mapper.Map<PersonnelListModel>(personnels);
            return mappedPersonnelListModel;

        }
    }
}