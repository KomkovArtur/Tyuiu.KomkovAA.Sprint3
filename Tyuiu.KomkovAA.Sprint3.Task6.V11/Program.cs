using Tyuiu.KomkovAA.Sprint3.Task6.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
        Console.WriteLine("* числовому отрезку [10, 19] количество всех делителей больше 10          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Начало отрезка = 10");
        Console.WriteLine("Конец отрезка = 19");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var res = ds.GetSumTheDivisors(10, 19);
        Console.WriteLine("Количество делителей больше 10 = " + res);
    }
}