using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class Validation
    {
        public OperationResult Validate(Person person)
        {
            var checkValidNationalCode = person.NationalCode.ValidateNationalCode();
            if (string.IsNullOrWhiteSpace(person.FirstName) ||
             string.IsNullOrWhiteSpace(person.LastName))
            {

                return OperationResult.Failed("لطفا همه فیلدها را پر کنید.");
            }
            else
             if (!checkValidNationalCode.IsSuccess)
            {
                return OperationResult.Failed(checkValidNationalCode.Message);
            }

            else
            if (person.Gender == Genders.None)
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
