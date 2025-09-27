using Tyuiu.SafronovVE.Sprint4.Task5.V12.Lib;
namespace Tyuiu.SafronovVE.Sprint4.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -6, 1, 2, -4, -2 }, { -5, -1, 3, 1, -4 }, { 1, 3, -4, -2, 1 }, { 1, 3, 2, -1, -2 }, { 3, 1, -2, -5, -6 } };
            int wait = 13;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);
        }
    }
}
