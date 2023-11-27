using CSharpOOPSpecialSeminar;

TestClass testClass = new TestClass(12, "Hello World", 12.4m, new char[] { 'a', 'b' });

string data = Lesson7.ObjectToString(testClass);
Console.WriteLine(data);

TestClass testClass1 = new TestClass();

Console.WriteLine();

Lesson7.StringToObject(data, testClass1);

Console.WriteLine(testClass1);