using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.ModelBinding;

namespace PersonManagement
{
    public class Person
    {
        [Required(ErrorMessage ="نام را وارد کنید")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="نام خانوادگی را وارد کنید")]
        public string LastName { get; set; }
        [NationalCodeValidation]
        public string NationalCode { get; set; }
        public Genders Gender { get; set; }

        public string GenderText
        {
            get
            {
                switch (Gender)
                {
                    case Genders.Male:
                        return "آقا";
                    case Genders.Female:
                        return "خانم";
                    default:
                        return "نامشخص";
                }
            }

        }
        public virtual string FullName => $"{FirstName} {LastName}";
        public virtual OperationResult Validate()
        {
            List<ValidationResult> validationResults = new List<ValidationResult>();
            StringBuilder stringBuilder = new StringBuilder();
            bool isValid = Validator.TryValidateObject(this, new ValidationContext(this), validationResults, true);
            foreach (var validationResult in validationResults)
            {
                stringBuilder.AppendLine(validationResult.ErrorMessage);
                return OperationResult.Failed(stringBuilder.ToString());
            }
             if (Gender == Genders.None)
            {

                return OperationResult.Failed(Messages.PleaseSelectGender);
            }
            else
            {
                return OperationResult.Success(Messages.InformationIsValid);
            }
        }
    }
}
