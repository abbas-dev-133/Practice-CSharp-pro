using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PersonManagement
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public OperationResult Validate()
        {
            var checkValidNationalCode = NationalCode.ValidateNationalCode();

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                return OperationResult.Failed("لطفا نام را وارد کنید");
            }
            else if (string.IsNullOrWhiteSpace(LastName))
            {

                return OperationResult.Failed("لطفا نام خانوادگی را وارد کنید");
            }
            else if (!checkValidNationalCode.IsSuccess)
            {
                return OperationResult.Failed(checkValidNationalCode.Message);
            }

            else if (Gender == Genders.None)
            {

                return OperationResult.Failed("لطفا جنسیت را انتخاب کنید");
            }
            else
            {
                return OperationResult.Success("اطلاعات وارد شده معتبر است");
            }
        }
    }
}
