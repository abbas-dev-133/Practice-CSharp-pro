using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class GenderValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is Genders gender && gender == Genders.None)
            {
                return new ValidationResult(Messages.PleaseSelectGender);
            }

            return ValidationResult.Success;
        }
    }
}
