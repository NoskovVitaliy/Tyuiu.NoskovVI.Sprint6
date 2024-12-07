using tyuiu.cources.programming.interfaces.Sprint6;
using System.Text;
namespace Tyuiu.NoskovVI.Sprint6.Task5.V23.Lib
{
    public class DataService : ISprint6Task5V23
    {
        public double[] LoadFromDataFile(string path)
        {
            int len = File.ReadLines(path).Count();
            double[] lines = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.EndOfStream == false)
                {
                    lines[index] = Convert.ToDouble(reader.ReadLine());
                    index++;
                }
            }
            lines = lines.Where(val => val < 0).ToArray();
            return lines;
        }
    }
}
