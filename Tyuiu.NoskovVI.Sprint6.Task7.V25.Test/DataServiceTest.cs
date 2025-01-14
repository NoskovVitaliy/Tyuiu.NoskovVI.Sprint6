﻿using Tyuiu.NoskovVI.Sprint6.Task7.V25.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void MatrixGetTest()
        {
            var ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask7V25.csv";
            int[,] wait = {{-17,  -17, 16,  -19, 10,  -15, -20, 4,   18,  19 },
                           {-13, -19, -4,  17,  13,  -11, -16, -1,  6,   10 },
                           {-19, -19, -6,  7,   3,   11,  8,   -16, -9,  -8 },
                           {-13, -13, 11,  -4,  7,   -20, 0,   0,   -6,  7 },
                           {-3,  20,  -15, 19,  3,   -4,  13,  -12, -18, 18 },
                           {-19, 18,  -18, -3,  11,  3,   9,   -13, 13,  15 },
                           {-19, 18,  -4,  -6,  15,  14,  12,  5,   18,  0 },
                           {-14, -9,  -14, 2,   0,   -9,  -1,  -10, 14,  - 9 },
                           {20,  -4,  -14, 6,   20,  12,  11,  9,   -20, -15 },
                           {-20, -8,  15,  -5,  0,   4,   15,  18,  -20, 11 } };
            CollectionAssert.AreEqual(ds.GetMatrix(path), wait);
                                                                    
        }
    }
}
