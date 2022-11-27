using Application.Features.Personnels.Commands;
using FluentValidation;

namespace Application.Features.Personnels.Validators;

public class CreatePersonnelCommandValidator : AbstractValidator<CreatePersonnelCommand>
{
    public CreatePersonnelCommandValidator()
    {


    }
}