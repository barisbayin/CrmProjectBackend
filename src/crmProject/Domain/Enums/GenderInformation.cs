using System.ComponentModel.DataAnnotations;

namespace Domain.Enums;

public enum GenderInformation
{
    [Display(Name = "Male")]
    M = 1,

    [Display(Name = "Female")]
    F = 2,

    [Display(Name = "Unspecified")]
    U = 3,
}