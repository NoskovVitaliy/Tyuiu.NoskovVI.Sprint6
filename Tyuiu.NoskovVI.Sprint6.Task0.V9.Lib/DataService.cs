using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NoskovVI.Sprint6.Task0.V9.Lib
{
    public class DataService : ISprint6Task0V9
    {
        public double Calculate(int x)
        {
            return Math.Round((4 - (double)(x * x * x)) / (double)(x * x),3);
        }
    }
}
