using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public abstract class BaseValidation
    {
        [Browsable(false)]
        public bool IsValid
        {
            get
            {
                var validationResults = new List<ValidationResult>();
                var c = new ValidationContext(this);
                bool isValid = Validator.TryValidateObject(this, c, validationResults, true);
                if (!isValid)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var validationResult in validationResults)
                    {
                        sb.AppendLine(validationResult.ErrorMessage);
                        break;
                    }
                    Error = sb.ToString();
                    return false;
                }
                return true;
            }
        }
        [Browsable(false)]
        public string Error { get; private set; }

    }
}
