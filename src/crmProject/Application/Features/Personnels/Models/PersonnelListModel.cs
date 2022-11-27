using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Personnels.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.Personnels.Models
{
    public class PersonnelListModel:BasePageableModel
    {
        public IList<PersonnelListDto> Items{ get; set; }
    }
}
