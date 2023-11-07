namespace CSharpOOPSpecialSeminar;

public interface ICalculate
{
    double Result { get; set; }
    void Sum(int x);
    void Subtract(int x);
    void Multiply(int x);
    void Divide(int x);

    void CancelLast();

    event EventHandler<EventArgs> MyEventHandler;
}
