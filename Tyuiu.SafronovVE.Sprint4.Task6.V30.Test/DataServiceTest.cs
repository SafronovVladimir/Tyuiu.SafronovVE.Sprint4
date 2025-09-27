using Tyuiu.SafronovVE.Sprint4.Task6.V30.Lib;
namespace Tyuiu.SafronovVE.Sprint4.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] array = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            var res = ds.Calculate(array);
            string[] wait = { "Береза" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
