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
        //public int Id { get; set; }
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
            if (string.IsNullOrWhiteSpace(FirstName) ||
             string.IsNullOrWhiteSpace(LastName))
            {

                return OperationResult.Failed("لطفا همه فیلدها را پر کنید.");
            }
            else
             if (!checkValidNationalCode.IsSuccess)
            {
                return OperationResult.Failed(checkValidNationalCode.Message);
            }

            else
            if (Gender == Genders.Unknown)
            {

                return OperationResult.Failed("لطفا جنسیت را انتخاب کنید.");
            }
            else
            {
                return OperationResult.Success("اطلاعات وارد شده معتبر است.");
            }
        }




    }
}
