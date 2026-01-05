using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.ModelBinding;

namespace PersonManagement
{
    public class Person: BaseValidation
    {
        [Required(ErrorMessage ="نام را وارد کنید")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="نام خانوادگی را وارد کنید")]
        public string LastName { get; set; }
        [NationalCodeValidation]
        public string NationalCode { get; set; }
        [GenderValidation]
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
    }
}
