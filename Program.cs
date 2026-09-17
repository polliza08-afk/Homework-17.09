// See https://aka.ms/new-console-template for more information
using MyStatic;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("---Ключове слова static---");

//Статичні методи можна викликати без потреби створення екзепляру класу
//Наприклад: Parse - це статичний метод, який перетворює рядок у число
int a = int.Parse("12");
Console.WriteLine("a = {0}", a); //Замість {0} - буде підставлятися параметр

//Змінити роботу метода ParseToInt, що міг числа s18 -> 18
//а число 23e45 -> 2345 = парс працював завжди

int s = MyParser.ParseToInt("18");
Console.WriteLine("My Parse result = " + s);