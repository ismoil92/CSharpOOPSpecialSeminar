namespace CSharpOOPSpecialSeminar;

public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Gender Sex { get; set; }
    public Person Father { get; set; } = null!;
    public Person Mother { get; set; } = null!;
    public List<Person> Childrens { get; set; } = new List<Person>();

    /// <summary>
    /// Метод, для добавление детей в список
    /// </summary>
    /// <param name="childs">массив детей</param>
    public void AddChildrens(params Person[] childs)
    {
        foreach (var child in childs)
            Childrens.Add(child);
    }


    /// <summary>
    /// Метод, для вывода генеологического дерево семьи
    /// </summary>
    /// <param name="family">член семьи класса Person</param>
    /// <param name="i"> отступ</param>
    public static void GenericTreeFamily(Person family, int i = 0)
    {
        family.Print(i);
        if (family.Childrens != null)
        {
            foreach (var child in family.Childrens)
            {
                GenericTreeFamily(child, i + 2);
            }
        }
    }

    /// <summary>
    /// Метод, для вывода всех членов семьи
    /// </summary>
    public void PrintFamily()
    {
        Console.WriteLine("DAD:" + this.Father.ToString());
        Console.WriteLine("MOM:" + this.Mother.ToString());
        if (this.Childrens.Count > 0 && this.Childrens != null)
        {
            Console.WriteLine("Have a children");
            foreach (var child in this.Childrens)
            {
                Console.WriteLine("CHILDREN:" + child.ToString());
            }
        }
        else
            Console.WriteLine("No children");
    }

    /// <summary>
    /// Метод, для вывода с отступом
    /// </summary>
    /// <param name="indent">отступ</param>
    public void Print(int indent)
    {
        Console.Write(new string('-', indent));
        Console.WriteLine(ToString());
    }

    /// <summary>
    /// Переопределенный метод, ToString()
    /// </summary>
    /// <returns>Возвращает имя и фамилию</returns>
    public override string ToString() => $"First Name:{FirstName}, Last Name:{LastName}";
}