using Tyuiu.StachinskiiVS.Sprint4.Task2.V26.Lib;

namespace Tyuiu.StachinskiiVS.Sprint4.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int wait = 135135;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}