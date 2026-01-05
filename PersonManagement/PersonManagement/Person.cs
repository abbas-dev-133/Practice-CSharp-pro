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
        [DgvDisplayName("نام")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="نام خانوادگی را وارد کنید")]
        [DgvDisplayName("نام خانوادگی")]
        public string LastName { get; set; }
        [NationalCodeValidation]
        [DgvDisplayName("کد ملی")]
        public string NationalCode { get; set; }
        [GenderValidation]
        public Genders Gender { get; set; }
        [DgvDisplayName("جنسیت")]
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
