namespace CSharpOOPSpecialSeminar;

public class Lesson8
{
    /// <summary>
    /// Метод, для нахождение файла, а также в файле нахождение искомое слово
    /// </summary>
    /// <param name="directory">Путь к директории</param>
    /// <param name="fileName">имя файла в директории</param>
    /// <param name="text">искомое слово в файле</param>
    /// <returns>возвращет true если искомое слово в файле найдена, false если искомое слово в файле не найдена</returns>
    /// <exception cref="DirectoryNotFoundException"> исключение если путь к файле не определен</exception>
    public static bool FindFileNameRecurs(string directory, string fileName, string text)
    {
        if (!Directory.Exists(directory))
        {
            Console.WriteLine($"{directory}, путь не найдена, проверьте правильно ли написана!!!!");
            throw new DirectoryNotFoundException();
        }

        var directories = Directory.GetDirectories(directory);

        foreach (var d in directories)
        {
            FindFileNameRecurs(d, fileName, text);
        }

        var files = Directory.GetFiles(directory);

        foreach (var f in files)
        {
            var _files = f.Split("\\");
            int length = _files.Length;
            if (_files[length - 1] == fileName)
            {
                using(StreamReader sr = new StreamReader(f))
                {
                    bool istrue = false;
                    while (!sr.EndOfStream)
                    {
                        
                        var value = sr.ReadLine();
                        if (value!.Contains(text))
                        {
                            istrue = true;
                            break;
                        }
                    }
                    if(istrue)
                    {
                        Console.WriteLine($"Файл {fileName}, в нём искомое слово {text} найдена!!!!!!!!!!");
                    }
                    else
                    {
                        Console.WriteLine($"Файл {fileName}, в нём искомое слово {text} не найдена!!!!!!!!!!");
                    }
                }
                return true;
            }
        }
        return false;
    }
}