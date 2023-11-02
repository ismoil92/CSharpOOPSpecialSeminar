namespace CSharpOOPSpecialSeminar;

public class Lesson4
{
    /// <summary>
    /// Статический метод, для вывода информации на консоль
    /// </summary>
    public static void PrintConsole()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 5, 11, 22, 0, 4, 6, 7, 9, 8, 10 };
        int target = 45;
        string input = string.Empty;
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 0; j < numbers.Count; j++)
            {
                for (int k = 0; k < numbers.Count; k++)
                {
                    if (numbers[i] + numbers[j] + numbers[k] == target)
                    {
                        input += $"Первый:{numbers[i]}, Второй:{numbers[j]}, Третий:{numbers[k]}\n";
                    }
                }
            }
        }

        Console.WriteLine(input);
    }
}