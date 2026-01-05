using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [MobileValidation]
        [DgvDisplayName("تلفن همراه")]
        public string Mobile 
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        [Required(ErrorMessage ="آدرس را وارد کنید")]
        [DgvDisplayName("آدرس")]
        public string Address { get; set; }
        [Required(ErrorMessage = "رشته تحصیلی را وارد کنید")]
        [DgvDisplayName("رشته تحصیلی")]
        public string Field { get; set; }
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
