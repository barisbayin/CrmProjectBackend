using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Enums
{
    public enum GenderInformation
    {
        [Display(Name = "Male")]
        M = 1,

        [Display(Name = "Female")]
        F = 2,

        [Display(Name = "Unspecified")]
        U = 3,
    }
}
