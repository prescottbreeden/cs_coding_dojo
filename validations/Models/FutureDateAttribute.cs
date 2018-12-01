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
        return new ValidationResult("Date must be valid.");
      }
      DateTime data = ( DateTime )value;
      DateTime now = DateTime.Now;
      if (data >= now) 
        return new ValidationResult("Date cannot be in the future!");
      return ValidationResult.Success;
    }
  }
}