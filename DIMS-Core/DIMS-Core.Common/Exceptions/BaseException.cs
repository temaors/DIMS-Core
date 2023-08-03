using System;

namespace DIMS_Core.Common.Exceptions
{
    /// <summary>
    ///     You can use this class for your custom exceptions
    /// </summary>
    public abstract class BaseException : Exception
    {
        public BaseException(string paramName) : base(paramName)
        {
            
        }

        public BaseException(string methodName, string message)
        {
        }
    }
}