using System;

namespace Core.Lib.Exceptions
{
    public class FengException : Exception
    {
        public FengException(string code)
        {
            ErrorCode = code;
        }
        public FengException(string code, string message) : base(message)
        {
            ErrorCode = code;
            ErrorMessage = message;
        }

        public FengException(string code, string message, Exception exception) : base(message, exception)
        {
            ErrorCode = code;
            ErrorMessage = message + exception.Message;
        }
        /// <summary>
        /// 错误码
        /// </summary>
        public string ErrorCode { get; set; }
        /// <summary>
        /// 错误描述
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
