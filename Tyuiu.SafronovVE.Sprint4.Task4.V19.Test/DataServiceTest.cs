using System.Numerics;
using Tyuiu.SafronovVE.Sprint4.Task4.V19.Lib;
namespace Tyuiu.SafronovVE.Sprint4.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 6, 7, 3, 5, 1 }, { 6, 5, 2, 2, 7 }, { 2, 6, 4, 6, 6 }, { 7, 5, 5, 2, 6 }, { 3, 1, 5, 7, 7 } };
            var res = ds.Calculate(matrix);
            var wait = 68;
            Assert.AreEqual(res, wait);
        }
    }
}
