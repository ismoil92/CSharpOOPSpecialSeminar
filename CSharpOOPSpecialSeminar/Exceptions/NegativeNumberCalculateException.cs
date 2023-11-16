namespace CSharpOOPSpecialSeminar.Exceptions;

public class NegativeNumberCalculateException : CalculateException
{
    public NegativeNumberCalculateException(string message) : base(message) { }
}