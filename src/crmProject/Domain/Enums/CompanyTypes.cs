using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Enums
{
    public enum CompanyTypes
    {
        [Display(Name = "Şahıs Şirketi")]
        PC = 1,

        [Display(Name = "Limited Şirket")]
        LC = 2,

        [Display(Name = "Anonim Şirket")]
        AC = 3,

    }
}
