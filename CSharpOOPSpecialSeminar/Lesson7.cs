using System.Reflection;
using System.Text;

namespace CSharpOOPSpecialSeminar;

public class Lesson7
{
    #region METHODS

    /// <summary>
    /// Статический метод, для преоброзавание из типа Object в строковой тип String
    /// </summary>
    /// <param name="obj">тип Object</param>
    /// <returns>Возвращает строковой тип String</returns>
    public static string ObjectToString(object obj)
    {
        StringBuilder sb = new StringBuilder();

        Type type = obj.GetType();

        foreach (PropertyInfo propertyInfo in type.GetRuntimeProperties())
        {
            CustomNameAttribute? custom = propertyInfo.GetCustomAttribute<CustomNameAttribute>();

            if (custom != null)
            {
                string fieldName = custom.Name;
                object? fieldValue = propertyInfo.GetValue(obj);


                sb.AppendFormat("{0}:{1}", fieldName, fieldValue);
                sb.AppendLine();
            }
        }
        return sb.ToString();
    }


    /// <summary>
    /// Статический метод, для преоброзавание из строковой тип String в тип Object 
    /// </summary>
    /// <param name="data">данные из строки</param>
    /// <param name="obj">Объект типа Object</param>
    public static void StringToObject(string data, object obj)
    {
        string[] lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string line in lines)
        {
            string[] keyValue = line.Split(":");

            string fieldName = keyValue[0].Trim();
            string fieldValue = keyValue[1].Trim();

            foreach (PropertyInfo propertyInfo in obj.GetType().GetRuntimeProperties())
            {
                CustomNameAttribute? customName = propertyInfo.GetCustomAttribute<CustomNameAttribute>();
                if (customName?.Name == fieldName)
                {
                    Type fieldType = propertyInfo.PropertyType;
                    object parsedValue = Convert.ChangeType(fieldValue, fieldType);

                    propertyInfo.SetValue(obj, parsedValue);

                    break;
                }
            }
        }
    }

    #endregion
}