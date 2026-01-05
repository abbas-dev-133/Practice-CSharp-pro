using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class MobileValidationAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {

            if (value == null)
            {
                ErrorMessage = Messages.MobileNumberInvalid;
                return false;
            }
            var mobile = (string)value;
            var result = mobile.ValidIranianMobile();
            if (mobile.Length > 11)
            {
                ErrorMessage = Messages.MobileLengthInvalid;
                return false;
            }
            if (!result.IsSuccess)
            {
                ErrorMessage = result.Message;
                return false;
            }
            return true;
        }
    }
}
