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
                return OperationResult.Failed(Messages.PleaseEnterFirstName);
            }
            else if (string.IsNullOrWhiteSpace(LastName))
            {

                return OperationResult.Failed(Messages.PleaseEnterLastName);
            }
            else if (!checkValidNationalCode.IsSuccess)
            {
                return OperationResult.Failed(checkValidNationalCode.Message);
            }

            else if (Gender == Genders.None)
            {

                return OperationResult.Failed(Messages.pleaseSelectGender);
            }
            else
            {
                return OperationResult.Success(Messages.InformationIsValid);
            }
        }
    }
}
