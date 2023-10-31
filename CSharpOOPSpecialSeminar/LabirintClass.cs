namespace CSharpOOPSpecialSeminar;

public class LabirintClass
{
    #region FIELDS
    static int[,] labirynth1 = new int[,]
    {
    {1, 1, 1, 1, 1, 1, 1 },
    {1, 0, 0, 0, 0, 0, 1 },
    {1, 0, 1, 1, 1, 0, 1 },
    {0, 0, 0, 0, 1, 0, 2 },
    {1, 1, 0, 0, 1, 1, 1 },
    {1, 1, 1, 0, 1, 1, 1 },
    {1, 1, 1, 2, 1, 1, 1 }
    };

    static int count;
    #endregion


    #region METHODS

    /// <summary>
    /// Метод, для нахождение выхода из лабиринта
    /// </summary>
    /// <param name="startI"> индекс строки двумерного массива</param>
    /// <param name="startJ">индекс столбца двумерного массива</param>
    /// <param name="l">двумерный массива</param>
    /// <param name="count">количество выхода</param>
    /// <returns>возвращает true, если есть выход, иначе false</returns>
    static bool HasExit(int startI, int startJ, int[,] l, out int count)
    {
        count = 0;
        var i = startI;
        var j = startJ;

        if (l[i, j] == 1)
        {
            return false;
        }
        else if (l[i, j] == 2)
        {
            count++;
            return true;
        }

        var stack = new Stack<Tuple<int, int>>();

        stack.Push(new(i, j));

        while (stack.Count > 0)
        {
            var temp = stack.Pop();

            if (l[temp.Item1, temp.Item2] == 2)
            {
                count++;
                if (count == 2)
                    return true;
            }

            l[temp.Item1, temp.Item2] = 1;

            if (temp.Item2 >= 0 && l[temp.Item1, temp.Item2 - 1] != 1)
                stack.Push(new(temp.Item1, temp.Item2 - 1)); //up

            if (temp.Item2 + 1 < l.GetLength(1) && l[temp.Item1, temp.Item2 + 1] != 1)
                stack.Push(new(temp.Item1, temp.Item2 + 1)); //down

            if (temp.Item1 >= 0 && l[temp.Item1 - 1, temp.Item2] != 1)
                stack.Push(new(temp.Item1 - 1, temp.Item2)); //left

            if (temp.Item1 + 1 < l.GetLength(0) && l[temp.Item1 + 1, temp.Item2] != 1)
                stack.Push(new(temp.Item1 + 1, temp.Item2));
        }

        return false;
    }

    /// <summary>
    /// Метод, для вывода информацию в консоль
    /// </summary>
    public static void DisplayConsole()
    {
        Console.WriteLine(HasExit(1, 3, labirynth1, out count));
        Console.WriteLine($"Количество выхода:{count}");
    }
    #endregion
}