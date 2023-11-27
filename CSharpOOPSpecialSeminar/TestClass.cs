namespace CSharpOOPSpecialSeminar;

public class TestClass
{

    #region PROPERTIES

    [CustomName("Integer")]
    public int I { get; set; }
    [CustomName("String")]
    public string S { get; set; } = string.Empty;
    [CustomName("Decimal")]
    public decimal D { get; set; }
    public char[]? C { get; set; }
    #endregion


    #region CONSTRUCTORS

    /// <summary>
    /// Конструктор без параметров
    /// </summary>
    public TestClass() { }

    /// <summary>
    /// Конструктор с одним параметров
    /// </summary>
    /// <param name="i">числовое значение</param>
    public TestClass(int i) => I = i;

    /// <summary>
    /// Конструктор с четыремя параметрами
    /// </summary>
    /// <param name="i">числовое значение</param>
    /// <param name="s">строковое значание</param>
    /// <param name="d">число с плавающие значением (decimal)</param>
    /// <param name="c">массив символов</param>
    public TestClass(int i, string s, decimal d, char[] c) : this(i)
    {
        this.S = s;
        this.D = d;
        this.C = c;
    }
    #endregion


    #region METHOD
    /// <summary>
    /// Переопределенный метод ToString, возвращает строку
    /// </summary>
    /// <returns>Возвращает строковой значение</returns>
    public override string ToString() => $"I:{I}, S:{S}, D:{D}, C:{C}";
    #endregion

}