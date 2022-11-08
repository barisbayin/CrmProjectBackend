namespace Core.Persistence.Repositories;

public class Entity
{
    public  int Id { get; set; }
    public bool Status { get; set; } = true;
    public DateTime CreationDate { get; set; } 
    public int CreatedById { get; set; }
    public DateTime? ModifiedDate { get; set; } 
    public int? ModifiedById { get; set; } 
    public bool? IsRemoved { get; set; } 
    public DateTime? RemovedDate { get; set; } = null;
    public int? RemovedById { get; set; } = null;

    public Entity()
    {
    }

    public Entity(int id) : this()
    {
        Id = id;
    }
}