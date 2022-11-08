using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Department : Entity
    {

        public string DepartmentName { get; set; }
        public string? Definition { get; set; }

        public Department()
        {
                
        }
        public Department(int id, string departmentName, string? definition) : base(id)
        {
            DepartmentName = departmentName;
            Definition = definition;
        }
    }
}
