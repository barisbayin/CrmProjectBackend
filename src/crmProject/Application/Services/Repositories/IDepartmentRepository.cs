using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IDepartmentRepository : IRepository<Department>, IAsyncRepository<Department>
{
}