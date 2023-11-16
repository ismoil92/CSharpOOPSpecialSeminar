namespace CSharpOOPSpecialSeminar.Exceptions;

public class DividedByZeroCalculateException : CalculateException
{
    public DividedByZeroCalculateException(string message) : base(message) { }
}