using Tyuiu.KomkovAA.Sprint3.Task0.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #25                                                              *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Написать программу используя цикл for,                                  *");
        Console.WriteLine("* которая вычисляет сумму ряда по формуле, при X=5.                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int value = 5;
        int startValue = 1;
        int stopValue = 14;
        Console.WriteLine("x = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("Сумму ряда = " + ds.GetSumSeries(value, startValue, stopValue));
    }
}