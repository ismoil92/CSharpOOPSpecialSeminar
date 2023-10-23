namespace CSharpOOPSpecialSeminar;

public class Bits : IBits
{
    #region CONSTRUCTORS
    /// <summary>
    /// Контруктор с параметром byte
    /// </summary>
    /// <param name="b">b с типом byte параметр</param>
    public Bits(byte b)
    {
        this.Value = b;
        MaxBitsCount = sizeof(byte) * 8;
    }

    /// <summary>
    /// Контруктор с параметром short
    /// </summary>
    /// <param name="b">b с типом short параметр</param>
    public Bits(short b)
    {
        this.Value = b;
        MaxBitsCount = sizeof(short) * 8;
    }

    /// <summary>
    /// Контруктор с параметром int
    /// </summary>
    /// <param name="b">b с типом int параметр</param>
    public Bits(int b)
    {
        this.Value = b;
        MaxBitsCount = sizeof(int) * 8;
    }

    /// <summary>
    /// Контруктор с параметром long
    /// </summary>
    /// <param name="b">b с типом long параметр</param>
    public Bits(long b)
    {
        this.Value = b;
        MaxBitsCount = sizeof(long) * 8;
    }

    #endregion

    #region PROPERTIES
    public long Value { get; set; } = 0;
    private int MaxBitsCount { get; set; }
    #endregion

    #region METHODS

    /// <summary>
    /// Метод, для получение бита
    /// </summary>
    /// <param name="index">индекс бита</param>
    /// <returns>возвращает true, если соответсвует условие, и false если не соответствует</returns>
    public bool GetBit(int index)
    {
        if (index > MaxBitsCount || index < 0)
        {
            Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
            return false;
        }

        return ((Value >> index) & 1) == 1;
    }

    /// <summary>
    /// Метод, для установки бита
    /// </summary>
    /// <param name="bit"> является ли битом</param>
    /// <param name="index">индекс бита</param>
    public void SetBit(bool bit, int index)
    {
        if (index > MaxBitsCount || index < 0)
        {
            Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
            return;
        }
        if (bit == true)
            Value = (byte)(Value | (1 << index));
        else
        {
            var mask = (byte)(1 << index);
            mask = (byte)(0xff ^ mask);
            Value &= (byte)(Value & mask);
        }
    }


    /// <summary>
    /// Оператор для неявного преобразование из byte в Bits
    /// </summary>
    /// <param name="val"> значение типа byte</param>
    public static implicit operator Bits(byte val)
    {
        return new Bits(val);
    }

    /// <summary>
    /// Оператор для явного преобразование из Bits в byte
    /// </summary>
    /// <param name="bits">значение типа Bites</param>
    public static explicit operator byte(Bits bits)
    {
        return (byte) bits.Value;
    }

    /// <summary>
    /// Оператор для неявного преобразование из short в Bits
    /// </summary>
    /// <param name="val"> значение типа short</param>
    public static implicit operator Bits(short val)
    {
        return new Bits(val);
    }

    /// <summary>
    /// Оператор для явного преобразование из Bits в short
    /// </summary>
    /// <param name="bits">значение типа Bites</param>
    public static explicit operator short(Bits bits)
    {
        return (short)bits.Value;
    }

    /// <summary>
    /// Оператор для неявного преобразование из int в Bits
    /// </summary>
    /// <param name="val"> значение типа int</param>
    public static implicit operator Bits(int val)
    {
        return new Bits(val);
    }

    /// <summary>
    /// Оператор для явного преобразование из Bits в int
    /// </summary>
    /// <param name="bits">значение типа Bites</param>
    public static explicit operator int(Bits val)
    {
        return (int)val.Value;
    }

    /// <summary>
    /// Оператор для неявного преобразование из long в Bits
    /// </summary>
    /// <param name="val"> значение типа long</param>
    public static implicit operator Bits(long val)
    {
        return new Bits(val);
    }

    /// <summary>
    /// Оператор для явного преобразование из Bits в int
    /// </summary>
    /// <param name="bits">значение типа Bites</param>
    public static explicit operator long(Bits bits)
    {
        return bits.Value;
    }
    #endregion
}