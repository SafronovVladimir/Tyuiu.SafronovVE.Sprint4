using Tyuiu.SafronovVE.Sprint4.Task2.V13.Lib;
namespace Tyuiu.SafronovVE.Sprint4.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 2, 6, 7, 2, 5 };
            var res = ds.Calculate(array);
            var wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}
