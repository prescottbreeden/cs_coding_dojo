using System;
using System.ComponentModel.DataAnnotations;

namespace validations.Models
{
  public class NoFutureDateAttribute : ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      if (value == null)
      {
        return new ValidationResult("Please enter a valid birthdate");
      }
      DateTime data = ( DateTime )value;
      DateTime now = DateTime.Now;
      if (data >= now.AddDays(-1)) 
        return new ValidationResult("Please enter a valid birthdate");
      return ValidationResult.Success;
    }
  }
}