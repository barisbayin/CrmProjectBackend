﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Departments.Dtos
{
    public class DeletedDepartmentDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Definition { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatedById { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedById { get; set; }
        public DateTime  RemovedDate { get; set; }
        public int RemovedById { get; set; }
    }
}