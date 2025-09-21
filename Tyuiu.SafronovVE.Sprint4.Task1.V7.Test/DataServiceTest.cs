using Tyuiu.SafronovVE.Sprint4.Task1.V7.Lib;
namespace Tyuiu.SafronovVE.Sprint4.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
            var res = ds.Calculate(array);
            var wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}
