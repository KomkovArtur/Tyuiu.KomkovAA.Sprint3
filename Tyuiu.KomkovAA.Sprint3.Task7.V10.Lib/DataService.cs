using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KomkovAA.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            List<double> mass = new List<double>();
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((Math.Sin(i) + 3) == 0)
                {
                    mass.Add(0);
                }
                else
                {
                    mass.Add(Math.Round((5 * i + 2.5) / (Math.Sin(i) + 3) + 2 * i + Math.Cos(i), 2));
                }
            }

            return mass.ToArray();

        }
    }
}
