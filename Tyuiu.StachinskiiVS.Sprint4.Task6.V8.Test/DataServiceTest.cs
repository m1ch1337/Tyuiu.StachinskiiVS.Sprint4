using Tyuiu.StachinskiiVS.Sprint4.Task6.V8.Lib;

namespace Tyuiu.StachinskiiVS.Sprint4.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string[] array = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            var res = ds.Calculate(array);
            string[] fs = new string[] { "Пицца", "Пельмени", "Омлет", "Салат", "Роллы" };
            CollectionAssert.AreEqual(res, fs);

        }
    }
}