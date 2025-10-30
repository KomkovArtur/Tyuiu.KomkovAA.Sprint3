using Tyuiu.KomkovAA.Sprint3.Task3.V13;
using Tyuiu.KomkovAA.Sprint3.Task3.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить   *");
        Console.WriteLine("* цифру затем преобразовать в число в строке: ?sd!! 5gh. s!               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string str = "?sd!! 5gh. s!";
        Console.WriteLine(str);
        int res = ds.ConvertStringToInt(str);
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine(res);
    }
}