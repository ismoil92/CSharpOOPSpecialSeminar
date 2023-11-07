namespace CSharpOOPSpecialSeminar;

public class Lesson5
{
    public static void PrintInformation()
    {
        Calculate calculate = new Calculate();

        calculate.MyEventHandler += Calculate_MyEventHandler;
        bool istrue = true;
        while (istrue)
        {
            Console.WriteLine("Введите символ: +, -, /, *");
            Console.Write("Введите символ:");
            if (Char.TryParse(Console.ReadLine(), out char result))
            {


                switch (result)
                {
                    case '+':
                        calculate.Sum(Random.Shared.Next(10));
                        break;
                    case '-':
                        calculate.Subtract(Random.Shared.Next(10));
                        break;
                    case '*':
                        calculate.Multiply(Random.Shared.Next(10));
                        break;
                    case '/':
                        calculate.Divide(Random.Shared.Next(10));
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


        void Calculate_MyEventHandler(object? sender, EventArgs e)
        {
            if (sender is Calculate calc)
                Console.WriteLine(((Calculate)sender)?.Result);
        }


    }
}