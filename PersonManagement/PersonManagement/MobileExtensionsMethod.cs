using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PersonManagement
{
    public static class MobileExtensionsMethod
    {
        public static OperationResult ValidIranianMobile(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return OperationResult.Failed("شماره موبایل وارد نشده است");

            string pattern = @"^09[0-9]{2}-?[0-9]{3}-?[0-9]{4}$";

            if (!Regex.IsMatch(input, pattern))
                return OperationResult.Failed("شماره موبایل نامعتبر است");

            return OperationResult.Success("شماره موبایل معتبر است");
        }
    }
}
