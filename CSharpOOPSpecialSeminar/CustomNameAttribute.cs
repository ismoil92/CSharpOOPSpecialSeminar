namespace CSharpOOPSpecialSeminar;

[AttributeUsage(AttributeTargets.Property)]
public class CustomNameAttribute : Attribute
{

    #region PROPERTY
    public string Name { get; }
    #endregion

    #region CONSTRUCTOR
    /// <summary>
    /// Конструктор с одним параметров
    /// </summary>
    /// <param name="name">имя строки</param>
    public CustomNameAttribute(string name) => Name = name;
    #endregion
}