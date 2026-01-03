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
           
            if (obj is Student other)
                 return other.StudentCode == this.StudentCode;
            return false;
        }
        public override string FullName => $"{base.FullName} - {Grade}";


        public override OperationResult Validate()
        {
            var baseResult = base.Validate();
            if (string.IsNullOrWhiteSpace(StudentCode))
                return OperationResult.Failed(Messages.StudentCodeIsRequired);

            if (string.IsNullOrWhiteSpace(Grade))
                return OperationResult.Failed(Messages.GradeIsRequired);

            return OperationResult.Success(Messages.InformationIsValid);
        }
        public Student Clone()
        {
            return new Student(this.StudentCode)
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                NationalCode = this.NationalCode,
                Grade = this.Grade,
                Gender = this.Gender
            };
        }
    }
}
