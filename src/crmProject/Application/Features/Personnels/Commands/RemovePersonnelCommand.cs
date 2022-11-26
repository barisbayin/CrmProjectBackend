using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Personnels.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Personnels.Commands
{
    public class RemovePersonnelCommand : IRequest<RemovedPersonnelDto>
    {
        public int Id { get; set; }
        public int RemovedById { get; set; }

        public class RemovePersonnelCommandHandler : IRequestHandler<RemovePersonnelCommand, RemovedPersonnelDto>
        {
            private readonly IPersonnelRepository _personnelRepository;
            private readonly IMapper _mapper;
            public RemovePersonnelCommandHandler(IPersonnelRepository personnelRepository, IMapper mapper)
            {
                _personnelRepository = personnelRepository;
                _mapper = mapper;
            }
            public async Task<RemovedPersonnelDto> Handle(RemovePersonnelCommand request, CancellationToken cancellationToken)
            {
                RemovedPersonnelDto removedPersonnelDto = new RemovedPersonnelDto();

                Personnel? personnelToBeRemoved= await _personnelRepository.GetAsync(p => p.Id == request.Id, cancellationToken: cancellationToken);

                if (personnelToBeRemoved == null) return removedPersonnelDto;

                personnelToBeRemoved.IsRemoved = true;
                personnelToBeRemoved.RemovedById = request.RemovedById;

                Personnel removedPersonnel =await _personnelRepository.UpdateAsync(personnelToBeRemoved);
                removedPersonnelDto = _mapper.Map<RemovedPersonnelDto>(removedPersonnel);

                return removedPersonnelDto;
            }
        }
    }
}
