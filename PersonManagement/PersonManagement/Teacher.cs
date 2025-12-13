using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class Teacher: Person
    {
        public string Mobile {  get; set; }
        public string Address { get; set; }
        public string Field { get; set; }

        public override OperationResult Validate()
        {
            var baseResult = base.Validate();
            var checkValiMobile = Mobile.ValidIranianMobile();
            if (!checkValiMobile.IsSuccess)
                return checkValiMobile;
            if (!baseResult.IsSuccess)
                return baseResult;

            if (string.IsNullOrWhiteSpace(Mobile))
                return OperationResult.Failed("تلفن همراه وارد نشده است");

            if (string.IsNullOrWhiteSpace(Address))
                return OperationResult.Failed("آدرس وارد نشده است");
            if (string.IsNullOrWhiteSpace(Field))
                return OperationResult.Failed("رشته وارد نشده است");

            return OperationResult.Success("اطلاعات معتبر است");
        }
    }
}
