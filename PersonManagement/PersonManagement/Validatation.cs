using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class Validation
    {
        Person Person;
        public Validation()
        {
            Person= new Person();
        }
        public OperationResult Validate()
        {
            var checkValidNationalCode = Person.NationalCode.ValidateNationalCode();
            if (string.IsNullOrWhiteSpace(Person.FirstName) ||
             string.IsNullOrWhiteSpace(Person.LastName))
            {

                return OperationResult.Failed("لطفا همه فیلدها را پر کنید.");
            }
            else
             if (!checkValidNationalCode.IsSuccess)
            {
                return OperationResult.Failed(checkValidNationalCode.Message);
            }

            else
            if (Person.Gender == Genders.Unknown)
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
