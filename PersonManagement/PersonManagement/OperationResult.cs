using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class OperationResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public static OperationResult Failed(string message)
        {
            return new OperationResult 
            {
                IsSuccess = false, Message = message 
            };
        }
        public static OperationResult Success(string message)
        {
            return new OperationResult
            {
                IsSuccess = true,
                Message = message
            };
        }
    }
}
