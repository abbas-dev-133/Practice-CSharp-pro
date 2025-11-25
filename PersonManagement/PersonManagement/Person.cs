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
            
           
            var checkValidNationalCode = NationalCode.ValidNationalCode();
            if (string.IsNullOrWhiteSpace(Name) ||
             string.IsNullOrWhiteSpace(FamilyName))
            {

                return OperationResult.Failed("لطفا همه فیلدها را پر کنید.");
            }
            else
             if (!checkValidNationalCode.IsSuccess)
            {  
                return OperationResult.Failed(checkValidNationalCode.Message);
            }
           
            else
            if (Gender==GenderType.Unknown)
            {
             
                return OperationResult.Failed("لطفا جنسیت را انتخاب کنید.");
            }
            else
            {
               return OperationResult.Success("اطلاعات وارد شده معتبر است.");
            }
          
        }


          

    }
}
