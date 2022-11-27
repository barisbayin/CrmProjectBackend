using System.ComponentModel.DataAnnotations;

namespace Domain.Enums;

public enum GenderInformation
{
    [Display(Name = "Male")]
    Male = 1,

    [Display(Name = "Female")]
    Female = 2,

    [Display(Name = "Unspecified")]
    Unspecified = 3,
}