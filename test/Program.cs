internal class Program
{
    private static void Main(string[] args)
    {
        double p = 1;
        int value = 5;
        int startValue = 1;
        int stopValue = 4;

        for (int k = startValue; k <= stopValue; k++)
        {
            double denominator = Math.Cos(value) + Math.Pow(value, k);
            double term = Math.Pow(300.0 / denominator, k);
            p *= term;
        }
        Console.WriteLine(p);
    }
}