namespace CSharpOOPSpecialSeminar;

public interface ICalculate
{
    double Result { get; set; }
    void Sum(int x, int y);
    void Sum(double x, double y);
    void Subtract(int x, int y);
    void Subtract(double x, double y);
    void Multiply(int x, int y);
    void Multiply(double x, double y);
    void Divide(int x, int y);
    void Divide(double x, double y);

    void CancelLast();

    event EventHandler<EventArgs> MyEventHandler;
}