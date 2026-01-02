 namespace PersonManagement
{
    public class Person
    {
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
        public virtual string FullName => $"{FirstName} {LastName}";
        public virtual OperationResult Validate()
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
