namespace Application.Features.Departments.Dtos;

public class CreatedDepartmentDto
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public string Definition { get; set; }
    public DateTime CreationDate { get; set; }
    public int CreatedById { get; set; }

}