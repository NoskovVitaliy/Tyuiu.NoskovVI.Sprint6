using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NoskovVI.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        {
            string result = string.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    foreach (string word in line.Split())
                    {

                        if (word.Contains('b')) result += word + " ";
                    }
                }
            }
            return result.TrimEnd();
        }
    }
}
