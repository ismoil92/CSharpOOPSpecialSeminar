using CSharpOOPSpecialSeminar.Exceptions;

namespace CSharpOOPSpecialSeminar;

public class Lesson6
{

    #region METHODS
    /// <summary>
    /// Метод, для вывода на экран
    /// </summary>
    public static void PrintInformation()
    {
        Calculate calculate = new Calculate();

        calculate.MyEventHandler += Calculate_MyEventHandler;
        bool istrue = true;
        double x=-1, y=-1;
        while (istrue) {
            try
            {
                if (calculate.Result < 0)
                {
                    istrue = false;
                    throw new NegativeNumberCalculateException("Сумма не должна быть отрицательной");
                }
                Console.Write("Введите первую число:");
                if (MyDoubleTryParse(Console.ReadLine()!, out double numb1))
                    x = numb1;
                Console.Write("Введите вторую число:");
                if (MyDoubleTryParse(Console.ReadLine()!, out double numb2))
                    y = numb2;
                if (x < 0 || y < 0)
                    throw new NegativeNumberCalculateException("Число не должна быть отрицательной");
                Console.WriteLine("Введите символ: +, -, /, *");
                Console.Write("Введите символ:");
                if (Char.TryParse(Console.ReadLine(), out char result))
                {


                    switch (result)
                    {
                        case '+':
                            calculate.Sum(x,y);
                            break;
                        case '-':
                            calculate.Subtract(x,y);
                            break;
                        case '*':
                            calculate.Multiply(x, y);
                            break;
                        case '/':
                                calculate.Divide(x, y);
                                break;
                            
                        default:
                            Console.WriteLine("\nНеверный оператор");
                            istrue = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nВыход из калькулятора");
                    istrue = false;
                }
            }
            catch (DividedByZeroCalculateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatCalculateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NegativeNumberCalculateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(CalculateException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    /// <summary>
    /// Метод, для конвертации из строки в вещественный число
    /// </summary>
    /// <param name="value">значение из строки</param>
    /// <param name="result">возвращает вещественную число через out</param>
    /// <returns>возвращет true, если успешно конвертирован, false выдал ошибку</returns>
    /// <exception cref="FormatCalculateException"></exception>
    private static bool MyDoubleTryParse(string value, out double result)
    {
        bool istrue = false;
        try
        {
            result = Convert.ToDouble(value);
            istrue = true;
            if (istrue)
            {
                return istrue;
            }
        }
        catch
        {
            throw new FormatCalculateException("Неверный формат");
        }
        return istrue;
    }

    
    /// <summary>
    /// Метод, для вывода результата на экран, добавляет к событию
    /// </summary>
    /// <param name="sender"> Объект класса Calculate для вывода результата на экран</param>
    /// <param name="e">Событие класса EventArgs</param>
    private static void Calculate_MyEventHandler(object? sender, EventArgs e)
    {
        if (sender is Calculate calc)
            Console.WriteLine(((Calculate)sender)?.Result);
    }

    #endregion
}