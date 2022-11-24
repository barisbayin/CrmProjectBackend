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
    public class DeletePersonnelCommand : IRequest<DeletedPersonnelDto>
    {
        public int Id { get; set; }
        public int RemovedById { get; set; }

        public class DeletePersonnelCommandHandler : IRequestHandler<DeletePersonnelCommand, DeletedPersonnelDto>
        {
            private readonly IPersonnelRepository _personnelRepository;
            private readonly IMapper _mapper;
            public DeletePersonnelCommandHandler(IPersonnelRepository personnelRepository, IMapper mapper)
            {
                _personnelRepository = personnelRepository;
                _mapper = mapper;
            }
            public async Task<DeletedPersonnelDto> Handle(DeletePersonnelCommand request, CancellationToken cancellationToken)
            {
                DeletedPersonnelDto deletedPersonnelDto = new DeletedPersonnelDto();

                Personnel? personnelToBeDeleted = await _personnelRepository.GetAsync(p => p.Id == request.Id, cancellationToken: cancellationToken);

                if (personnelToBeDeleted == null) return deletedPersonnelDto;

                personnelToBeDeleted.IsRemoved = true;
                personnelToBeDeleted.RemovedById = request.RemovedById;

                deletedPersonnelDto = _mapper.Map<DeletedPersonnelDto>(personnelToBeDeleted);

                return deletedPersonnelDto;
            }
        }
    }
}
