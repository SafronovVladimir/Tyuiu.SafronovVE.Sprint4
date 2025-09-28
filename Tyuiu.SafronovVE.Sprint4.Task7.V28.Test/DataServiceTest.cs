using System.Data;
using Tyuiu.SafronovVE.Sprint4.Task7.V28.Lib;
namespace Tyuiu.SafronovVE.Sprint4.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string str = "623351179845632";
            int rows = 5;
            int cols = 3;
            int wait = 4608;
            int res = ds.Calculate(rows, cols, str);
            Assert.AreEqual(wait, res);
        }
    }
}
