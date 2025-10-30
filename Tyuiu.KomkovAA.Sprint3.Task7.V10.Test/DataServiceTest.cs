using Tyuiu.KomkovAA.Sprint3.Task7.V10;
using Tyuiu.KomkovAA.Sprint3.Task7.V10.Lib;
namespace Tyuiu.KomkovAA.Sprint3.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var var = 1.83;
            Assert.AreEqual(var, ds.GetMassFunction(0, 1)[0]);
        }
    }
}
