namespace Application.Features.Departments.Dtos;

public class RemovedDepartmentDto
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public string Definition { get; set; }
    public int Status { get; set; }
    public DateTime CreationDate { get; set; }
    public int CreatedById { get; set; }
    public DateTime ModifiedDate { get; set; }
    public int ModifiedById { get; set; }
    public DateTime  RemovedDate { get; set; }
    public int RemovedById { get; set; }
}