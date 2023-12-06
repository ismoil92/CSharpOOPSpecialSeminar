using Newtonsoft.Json;
using System.Xml;

namespace CSharpOOPSpecialSeminar;

public class Lesson9
{
    /// <summary>
    /// Статический метод, конвертация из json в xml
    /// </summary>
    /// <returns>Возвращает xml файл</returns>
    private static XmlDocument GetConvertJSONToXml()
    {
        string json = "{\"browsers\":{\"firefox\":{\"name\":\"Firefox\",\"pref_url\":\"about:config\",\"releases\":{\"1\":{\"release_date\":\"2004-11-09\",\"status\":\"retired\",\"engine\":\"Gecko\",\"engine_version\":\"1.7\"}}}}}";

        var xml = JsonConvert.DeserializeXmlNode(json);

        return xml!;
    }



    /// <summary>
    /// Вывод XML документа на консоль
    /// </summary>
    public static void PrintXmlDocument()
    {
        var xml = GetConvertJSONToXml();
        xml.Save(Console.Out);
        Console.WriteLine("\n");
    }
}