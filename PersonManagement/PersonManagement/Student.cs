using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class Student : Person
    {
        private string _studentCode;
        public Student(string studentCode)
        {
            _studentCode = studentCode;
        }
        public string StudentCode
        {
            get { return _studentCode; } 
        }
        public string Grade { get; set; }
        public override string ToString()
        {
            return $"{FullName}-{NationalCode}-{Grade}-{StudentCode}";
        }
        public override bool Equals(object obj)
        {
            var other = obj as Student;
            if (other == null)
                return false;
            return other.StudentCode == this.StudentCode;
        }
        public override string FullName => $"{base.FullName} - {Grade}";


        public override OperationResult Validate()
        {
            var baseResult = base.Validate();
            var checkValidNationalCode = NationalCode.ValidateNationalCode();
            if (!baseResult.IsSuccess)
                return baseResult;

            if (string.IsNullOrWhiteSpace(StudentCode))
                return OperationResult.Failed("کد دانش‌آموزی وارد نشده است");

            if (string.IsNullOrWhiteSpace(Grade))
                return OperationResult.Failed("مقطع تحصیلی وارد نشده است");

            return OperationResult.Success("اطلاعات معتبر است");
        }
    }
}
