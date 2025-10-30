using Tyuiu.KomkovAA.Sprint3.Task1.V9.Lib;
namespace Tyuiu.KomkovAA.Sprint3.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double expected = 5815.752;
            double actual = ds.GetMultiplySeries(5, 1, 4);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
