using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagement
{
    public static class Messages
    {
        public static string PleaseEnterFirstName = "لطفا نام را وارد کنید";
        public static string PleaseEnterLastName = "لطفا نام خانوادگی را وارد کنید";
        public static string pleaseSelectGender = "لطفا جنسیت را انتخاب کنید";
        
        public static string InformationIsValid = "اطلاعات وارد شده معتبر است";

        public static string GradeIsRequired = "مقطع تحصیلی وارد نشده است";
        public static string StudentCodeIsRequired = "کد دانش‌آموزی وارد نشده است";

        public static string StudentFoundSuccessfully = "دانش آموز با موفقیت پیدا شد";
        public static string StudentNotFound = "دانش آموز پیدا نشد";

        public static string DuplicateStudentCode = "کد دانشجویی تکراری است";
        public static string DuplicateNationalCode = " کد ملی تکراری است";

        public static string StudentCreatedSuccessfully = "دانشجو با موفقیت ثبت شد";
        public static string StudentUpdatedSuccessfully = "دانشجو با موفقیت ویرایش شد";

        public static string MobileNumberIsRequired = "تلفن همراه وارد نشده است";
        public static string AddressIsRequired = "آدرس وارد نشده است";
        public static string FieldOfStudyIsRequired = "رشته وارد نشده است";

        public static string DuplicateMobileNumber = "شماره موبایل تکراری است";

        public static string TeacherCreatedSuccessfully = "معلم با موفقیت ثبت شد";
        public static string TeacherNotFound = "معلم یافت نشد";
        public static string TeacherUpdatedSuccessfully = "معلم با موفقیت ویرایش شد";

        public static string NationalCodeLengthInvalid = "کد ملی باید 10 رقم باشد";
        public static string NationalCodeInvalid = "کد ملی معتبر نیست";
        public static string NationalCodeValid = "کد ملی معتبر است";

        public static string MobileNumberInvalid = "شماره موبایل معتبر نیست";
        public static string MobileNumberValid = "شماره موبایل معتبر است";

        public static string PleaseSelectRow = "یک ردیف را انتخاب کنید";

    }
}
