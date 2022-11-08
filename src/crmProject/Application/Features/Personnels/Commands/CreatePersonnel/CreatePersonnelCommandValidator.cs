using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Application.Features.Personnels.Commands.CreatePersonnel
{
    public class CreatePersonnelCommandValidator : AbstractValidator<CreatePersonnelCommand>
    {
        public CreatePersonnelCommandValidator()
        {
            

        }
    }
}
