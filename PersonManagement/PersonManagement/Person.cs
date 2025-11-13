using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagement
{
    public enum GenderType
    {
        Male,
        Female,
        Unknown
    }
    
    public class Person
    {
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string NationalCode { get; set; }
        public GenderType Gender { get; set; }


    }
}
