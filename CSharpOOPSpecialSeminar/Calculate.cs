using CSharpOOPSpecialSeminar.Exceptions;

namespace CSharpOOPSpecialSeminar;

public class Calculate : ICalculate
{

    #region FIELDS
    public double Result { get; set; } = 0D;
    public Stack<double> LastResult { get; set; } = new Stack<double>();
    public event EventHandler<EventArgs>? MyEventHandler;
    #endregion

    #region METHODS
    /// <summary>
    /// Метод, для выполнение операции деление
    /// </summary>
    /// <param name="x">первое число целочисленное</param>
    /// <param name="y">второе число целочисленное</param>
    /// <exception cref="DivideByZeroException"> исключение при возникновение деление на ноль</exception>
    public void Divide(int x, int y)
    {
        if (y != 0)
        {
            Result = x / y;
            Print();
            LastResult.Push(Result);
            return;
        }
        throw new DivideByZeroException("Деление на ноль запрещено");

    }

    /// <summary>
    /// Метод, для выполнение операции умножение
    /// </summary>
    /// <param name="x">первое число целочисленное</param>
    /// <param name="y">второе число целочисленное</param>
    public void Multiply(int x, int y)
    {
        Result = x * y;
        Print();
        LastResult.Push(Result);
    }

    /// <summary>
    /// Метод, для выполнение операции вычитание
    /// </summary>
    /// <param name="x">первое число целочисленное</param>
    /// <param name="y">второе число целочисленное</param>
    public void Subtract(int x, int y)
    {
        Result = x - y;
        Print();
        LastResult.Push(Result);
    }

    /// <summary>
    /// Метод, для выполнение операции сложение
    /// </summary>
    /// <param name="x">первое число целочисленное</param>
    /// <param name="y">второе число целочисленное</param>
    public void Sum(int x, int y)
    {
        Result = x+y;
        Print();
        LastResult.Push(Result);
    }

    /// <summary>
    /// Метод, для отмены операции (сложениеб вычитаниеб умножение и деление)
    /// </summary>
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

    /// <summary>
    /// Метод, для вывода результата операции
    /// </summary>
    private void Print() => MyEventHandler?.Invoke(this, EventArgs.Empty);


    /// <summary>
    /// Метод, для выполнение операции сложение
    /// </summary>
    /// <param name="x">первое число вещественное типа</param>
    /// <param name="y">второе число вещественное типа</param>
    public void Sum(double x, double y)
    {
        Result = x + y;
        Print();
        LastResult.Push(Result);
    }


    /// <summary>
    /// Метод, для выполнение операции вычитание
    /// </summary>
    /// <param name="x">первое число вещественное типа</param>
    /// <param name="y">второе число вещественное типа</param>
    public void Subtract(double x, double y)
    {
        Result = x - y;
        Print();
        LastResult.Push(Result);
    }

    /// <summary>
    /// Метод, для выполнение операции умножение
    /// </summary>
    /// <param name="x">первое число вещественное типа</param>
    /// <param name="y">второе число вещественное типа</param>
    public void Multiply(double x, double y)
    {
        Result = x * y;
        Print();
        LastResult.Push(Result);
    }

    /// <summary>
    /// Метод, для выполнение операции деление
    /// </summary>
    /// <param name="x">первое число вещественного типа</param>
    /// <param name="y">второе число вещественного типа</param>
    /// <exception cref="DivideByZeroException"> исключение при возникновение деление на ноль</exception>
    public void Divide(double x, double y)
    {
        if (y != 0)
        {
            Result = x / y;
            Print();
            LastResult.Push(Result);
            return;
        }
        else
            throw new DividedByZeroCalculateException("На ноль делить нельзя");
    }
    #endregion
}