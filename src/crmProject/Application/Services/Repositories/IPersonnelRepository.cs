using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IPersonnelRepository : IRepository<Personnel>, IAsyncRepository<Personnel>
{
}