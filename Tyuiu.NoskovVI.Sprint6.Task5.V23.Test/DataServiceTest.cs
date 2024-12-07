using Tyuiu.NoskovVI.Sprint6.Task5.V23.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LinesTest()
        {
            var ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask5V23.txt";
            double[] lines = { -17, -14.32, -7.84, -1.57,-3.64, -13.26, -8.91, -17.77, -9, -1.49, -7 };
            CollectionAssert.AreEqual(lines, ds.LoadFromDataFile(path));

        }
    }
}
