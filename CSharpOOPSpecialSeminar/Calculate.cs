namespace CSharpOOPSpecialSeminar;

public class Calculate : ICalculate
{

    public double Result { get; set; } = 0D;
    public Stack<double> LastResult { get; set; } = new Stack<double>();
    public event EventHandler<EventArgs> MyEventHandler;

    public void Divide(int x)
    {
        Result /= x;
        Print();
        LastResult.Push(Result);
    }

    public void Multiply(int x)
    {
        Result *= x;
        Print();
        LastResult.Push(Result);
    }

    public void Subtract(int x)
    {
        Result -= x;
        Print();
        LastResult.Push(Result);
    }

    public void Sum(int x)
    {
        Result += x;
        Print();
        LastResult.Push(Result);
    }

    public void CancelLast()
    {
        if (LastResult.TryPop(out double res))
        {
            Result = res;
            Console.WriteLine($"Last result:{Result}");
            Print();
        }
        else
            Console.WriteLine("Error message");

    }

    private void Print() => MyEventHandler?.Invoke(this, EventArgs.Empty);
}
