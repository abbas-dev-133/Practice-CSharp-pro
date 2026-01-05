using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "کد دانشجویی را وارد کنید")]
        [DgvDisplayName("کد دانش آموزی")]
        public string StudentCode
        {
            get { return _studentCode; } 
            set { _studentCode = value; }
        }
        [Required(ErrorMessage ="مقطع تحصیلی را وارد کنید")]
        [DgvDisplayName("مقطع تحصیلی")]
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
