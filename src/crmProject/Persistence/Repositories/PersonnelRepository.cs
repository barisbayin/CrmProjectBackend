using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class PersonnelRepository : EfRepositoryBase<Personnel, BaseDbContext>, IPersonnelRepository
{
    public PersonnelRepository(BaseDbContext context) : base(context)
    {
    }
}