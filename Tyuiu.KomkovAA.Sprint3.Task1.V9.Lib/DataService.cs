using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KomkovAA.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                double denominator = Math.Cos(value) + Math.Pow(value, k);
                double term = Math.Pow(300.0 / denominator, k);
                p *= term;
            }

            return Math.Round(p, 3);
        }
    }
}
