using Tyuiu.KomkovAA.Sprint3.Task3.V13;
using Tyuiu.KomkovAA.Sprint3.Task3.V13.Lib;
namespace Tyuiu.KomkovAA.Sprint3.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "?sd!! 5gh. s!";
            double res = ds.ConvertStringToInt(value);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
