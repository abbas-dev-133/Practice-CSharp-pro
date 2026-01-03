using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class NationalCodeValidationAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                ErrorMessage = Messages.NationalCodeValid;
                return false; 
            }
            var nationalCode = (string)value;
            var result = nationalCode.ValidateNationalCode();
            if(nationalCode.Length<10)
            {
                ErrorMessage = Messages.NationalCodeLengthInvalid;
                return false;
            }
            if(!result.IsSuccess)
            {
                ErrorMessage = result.Message;
                return false;
            }
            return true;
        }
    }
}
