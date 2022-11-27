using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IPersonnelRepository : IAsyncRepository<Personnel>, IRepository<Personnel>
{
}