using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Departments.Dtos
{
    public class CreatedDepartmentDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Definition { get; set; }
    }
}
