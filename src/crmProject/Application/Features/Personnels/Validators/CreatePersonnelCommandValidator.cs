using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Personnels.Commands;
using FluentValidation;

namespace Application.Features.Personnels.Validators
{
    public class CreatePersonnelCommandValidator : AbstractValidator<CreatePersonnelCommand>
    {
        public CreatePersonnelCommandValidator()
        {


        }
    }
}
