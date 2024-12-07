﻿using Tyuiu.NoskovVI.Sprint6.Task4.V19.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void MassCheck()
        {
            var ds = new DataService();
            int start = -5;
            int end = 5;
            double[] wait = new double[end - start + 1];
            wait[0] = 23.61;
            wait[1] = 16.08;
            wait[2] = 7.84;
            wait[3] = 4.58;
            wait[4] = 2.88;
            wait[5] = 0.75;
            wait[6] = - 4.47;
            wait[7] = - 9.46;
            wait[8] = - 7.41;
            wait[9] = - 6.16;
            wait[10] = - 7.29;
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(start, end));
        }
    }
}
