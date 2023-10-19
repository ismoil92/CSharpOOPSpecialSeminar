namespace CSharpOOPSpecialSeminar;

public class Display
{
    /// <summary>
    /// Метод, для вывода на консоль генеологического дерево семьи
    /// </summary>
    public static void PrintConsole()
    {
        // My Family
        Person dad = new Person { FirstName = "Ahmad", LastName = "Muhammadiev", Sex = Gender.Male, Father = null!, Mother = null! };
        Person mom = new Person { FirstName = "Gulya", LastName = "Azimova", Sex = Gender.Female, Father = null!, Mother = null! };
        Person me = new Person { FirstName = "Ismoil", LastName = "Muhammadiev", Sex = Gender.Male, Father = dad, Mother = mom };
        Person brother = new Person { FirstName = "Chingiz", LastName = "Muhammadiev", Sex = Gender.Male, Father = dad, Mother = mom };
        Person sister = new Person { FirstName = "Guzaliya", LastName = "Muhammadiev", Sex = Gender.Female, Father = dad, Mother = mom };
        Person son = new Person { FirstName = "Amir", LastName = "Muhammadiev", Sex = Gender.Male, Father = me, Mother = null! };
        Person safiya = new Person { FirstName = "Safiya", LastName = "Shafikova", Sex = Gender.Female, Father = null!, Mother = sister };

        // Family wife
        Person wifesDad = new Person { FirstName = "Ali", LastName = "Ergashev", Sex = Gender.Male, Mother = null!, Father = null! };
        Person wifesMom = new Person { FirstName = "Dilfuza", LastName = "Shoymardonova", Sex = Gender.Female, Mother = null!, Father = null! };
        Person wife = new Person { FirstName = "Nigora", LastName = "Ergasheva", Sex = Gender.Female, Father = wifesDad, Mother = wifesMom };
        Person wifesSister1 = new Person { FirstName = "Shaxzoda", LastName = "Ergasheva", Sex = Gender.Female, Mother = wifesMom, Father = wifesDad };
        Person wifesSister2 = new Person { FirstName = "Zari", LastName = "Ergasheva", Sex = Gender.Female, Father = wifesDad, Mother = wifesMom };


        dad.AddChildrens(me, brother, sister);
        mom.AddChildrens(me, brother, sister);

        me.AddChildrens(son);
        wife.AddChildrens(son);
        sister.AddChildrens(safiya);

        wifesDad.AddChildrens(wife, wifesSister1, wifesSister2);
        wifesMom.AddChildrens(wife, wifesSister1, wifesSister2);

        Console.WriteLine("My Family");
        Person.GenericTreeFamily(dad);
        Console.WriteLine("=================================");
        Console.WriteLine("Wifes Family");
        Person.GenericTreeFamily(wifesDad);
    }
}