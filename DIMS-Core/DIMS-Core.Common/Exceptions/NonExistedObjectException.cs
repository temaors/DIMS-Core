namespace DIMS_Core.Common.Exceptions;

public class NonExistedObjectException : BaseException
{
    public NonExistedObjectException(string paramName) : base(paramName)
    {
    }

    public NonExistedObjectException(string methodName, string message) : base(methodName, message)
    {
    }
}