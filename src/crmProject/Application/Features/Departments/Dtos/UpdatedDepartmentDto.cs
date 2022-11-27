namespace Application.Features.Departments.Dtos;

public class UpdatedDepartmentDto
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public string Definition { get; set; }
    public DateTime CreationDate { get; set; }
    public int CreatedById { get; set; }
    public DateTime ModifiedDate { get; set; }
    public int ModifiedById { get; set; }
}