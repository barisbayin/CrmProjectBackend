using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using Core.Persistence.Repositories;

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
                data.Entity.Status = false;
                return await base.SaveChangesAsync(cancellationToken);
            }

            switch (data.State)
            {
                case EntityState.Added:
                    data.Entity.CreationDate = DateTime.Now;
                    data.Entity.Status = true;
                    data.Entity.IsRemoved = false;
                    break;
                case EntityState.Modified:
                    data.Entity.ModifiedDate = DateTime.Now;
                    break;
            }
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