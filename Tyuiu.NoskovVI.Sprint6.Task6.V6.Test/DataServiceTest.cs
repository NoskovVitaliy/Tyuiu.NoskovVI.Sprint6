using Tyuiu.NoskovVI.Sprint6.Task6.V6.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CollectTest()
        {
            var ds = new DataService();   
            string path = @"C:\DataSprint6\InPutDataFileTask6V6.txt";
            string wait = "lG YebQ BV ypiUHHFJ eAezSXF aPIjKf zCOZQ Qxv HbJcPW wUdVEuNB aidoqRW";
            Assert.AreEqual(ds.CollectTextFromFile(path), wait);   
        }
    }
}
