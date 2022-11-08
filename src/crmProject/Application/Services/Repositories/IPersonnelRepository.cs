﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IPersonnelRepository : IAsyncRepository<Personnel>, IRepository<Personnel>
    {
    }
}
