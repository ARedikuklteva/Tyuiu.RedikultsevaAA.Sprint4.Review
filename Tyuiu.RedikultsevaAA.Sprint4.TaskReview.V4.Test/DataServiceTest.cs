using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint4.TaskReview.V4.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int rows = 3;
            int colums = 4;
            int[,] matrix = new int[rows, colums];
            string str = "382976421897";

            int res = ds.Calculate(rows, colums, str);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}
