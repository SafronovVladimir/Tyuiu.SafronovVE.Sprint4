using Tyuiu.SafronovVE.Sprint4.Task3.V23.Lib;
namespace Tyuiu.SafronovVE.Sprint4.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 7, 5, 5, 6, 7 }, { 8, 7, 8, 4, 3 }, { 5, 6, 7, 8, 3 }, { 4, 2, 3, 6, 4 }, { 5, 2, 4, 2, 3 } };
            int wait = 13;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
