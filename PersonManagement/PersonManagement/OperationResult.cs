using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class OperationResult
    {
        private OperationResult(bool isSuccess, string message)
        {
           IsSuccess= isSuccess;
            Message = message;
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public static OperationResult Failed(string message)
        {
            return new OperationResult(false, message);
        }
        public static OperationResult Success(string message)
        {
            return new OperationResult(true, message);
        }
    }
}
