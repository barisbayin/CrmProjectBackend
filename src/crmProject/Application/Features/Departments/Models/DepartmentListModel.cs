using Application.Features.Departments.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.Departments.Models;

public class DepartmentListModel : BasePageableModel
{
    public IList<DepartmentListDto> Items { get; set; }
}