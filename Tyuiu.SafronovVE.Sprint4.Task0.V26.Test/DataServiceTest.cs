using Tyuiu.SafronovVE.Sprint4.Task0.V26.Lib;
namespace Tyuiu.SafronovVE.Sprint4.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int wait = 41;
            int res = ds.GetSumOddArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}
