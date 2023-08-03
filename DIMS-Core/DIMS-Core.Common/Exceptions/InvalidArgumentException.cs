namespace DIMS_Core.Common.Exceptions;

public class InvalidArgumentException : BaseException
{
    public InvalidArgumentException(string paramName) : base(paramName)
    {
    }
}