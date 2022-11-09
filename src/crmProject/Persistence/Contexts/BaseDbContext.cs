using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Domain.Entities;

namespace Persistence.Contexts;
public class BaseDbContext : DbContext
{
    private IConfiguration Configuration { get; set; }

    public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {

        IEnumerable<EntityEntry<Entity>> datas = ChangeTracker.Entries<Entity>();

        foreach (var data in datas)
        {
            if (data.Entity.IsRemoved == true)
            {
                data.Entity.RemovedDate = DateTime.Now;
                return await base.SaveChangesAsync(cancellationToken);
            }

            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreationDate = DateTime.Now,
                EntityState.Modified => data.Entity.ModifiedDate = DateTime.Now,
            };
        }
        return await base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            base.OnConfiguring(optionsBuilder.UseSqlServer(Configuration.GetConnectionString("CrmProjectConnectionString")));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


    }
}
