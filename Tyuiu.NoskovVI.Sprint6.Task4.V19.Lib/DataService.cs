using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NoskovVI.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int index = 0;
            double[] result = new double[stopValue-startValue+1];
            for (int i = startValue; i <= stopValue; i++)
            {
                result[index] = Math.Round(((5d * (double)i + 2.5) / (Math.Sin(i) - 2d)) + 2d,2);
                index++;
            }
            return result;
        }
    }
}
