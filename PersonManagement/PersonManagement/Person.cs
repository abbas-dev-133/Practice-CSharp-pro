using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PersonManagement
{
	public enum GenderType
	{
		Male,
		Female,
		Unknown
	}
	
	public  class  Person
	{
        
        public string Name { get; set; }
		public string FamilyName { get; set; }
		public string NationalCode { get; set; }
		public GenderType Gender { get; set; }
   
		public OperationResult Validate()
		{
            
            var result = new OperationResult();
            var isValidNationalCode = NationalCode.NationalCodeValidate();
            if (string.IsNullOrWhiteSpace(Name) ||
             string.IsNullOrWhiteSpace(FamilyName))
            {
                result.Message = "لطفا همه فیلدها را پر کنید.";
                result.IsSuccess=false;
            }
            else
             if (!isValidNationalCode.IsSuccess)
            {
                result.IsSuccess = false;
                result.Message = isValidNationalCode.Message;
            }
           
            else
            if (Gender==GenderType.Unknown)
            {
                result.Message = "لطفا جنسیت را انتخاب کنید.";
                result.IsSuccess = false;
            }
            else
            {
                result.IsSuccess = true;
            }
            return result;
        }


          

    }
}
