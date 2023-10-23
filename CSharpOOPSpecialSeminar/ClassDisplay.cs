namespace CSharpOOPSpecialSeminar;

public class ClassDisplay
{
    /// <summary>
    /// Статический метод, для вывода информации
    /// </summary>
    public static void ConsolePrint()
    {
        Bits bits = new Bits(5);

        //byte

        byte _byte = (byte)bits;
        byte _byte2 = 3;
        bits = _byte2;

        Console.WriteLine($"_byte:{_byte}, Byte bits:{bits.Value}");


        //short

        short _short = (short)bits;
        short _short2 = 2;
        bits = _short2;
        Console.WriteLine($"_short:{_short}, Short bits:{bits.Value}");



        //int

        int a = (int)bits;
        int b = 1;
        bits = b;

        Console.WriteLine($"a:{a}, Int bits:{bits.Value}");

        //long
        long _long = (long)bits;
        long _long2 = 4;
        bits = _long2;

        Console.WriteLine($"_long:{_long}, Long bits:{bits.Value}");
    }
}