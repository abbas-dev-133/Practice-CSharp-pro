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
        private string _mobile;
        public Teacher(string mobile)
        {
            _mobile = mobile;
        }
        public string Mobile 
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
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
                return OperationResult.Failed(Messages.MobileNumberIsRequired);

            if (string.IsNullOrWhiteSpace(Address))
                return OperationResult.Failed(Messages.AddressIsRequired);
            if (string.IsNullOrWhiteSpace(Field))
                return OperationResult.Failed(Messages.FieldOfStudyIsRequired);

            return OperationResult.Success(Messages.InformationIsValid);
        }
        public Teacher Clone()
        {
            return new Teacher(this.Mobile)
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                NationalCode = this.NationalCode,
                Gender = this.Gender,
                Address = this.Address,
                Field = this.Field
            };
        }
    }
}
