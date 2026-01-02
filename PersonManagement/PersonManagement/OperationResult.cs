using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class OperationResult
    {
        protected OperationResult(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        public object Data { get; private set; }
        public bool IsSuccess { get; private set; }
        public string Message { get; private set; }
        public static OperationResult Failed(string message)
        {
            return new OperationResult(false, message);
        }
        public static OperationResult Success(string message)
        {
            return new OperationResult(true, message);
        }
    }
    public class OperationResult<T> : OperationResult
    {
        public T Data { get;  set; }
        private OperationResult(bool isSuccess, string message, T data): base(isSuccess, message) 
        {
            Data = data;
        }
        public static OperationResult<T> Failed(string message)
        {
            return new OperationResult<T>(false, message,default);
        }
        public static OperationResult<T> Success(string message, T data)
        {
            return new OperationResult<T>(true, message,data);
        }
    }
}
