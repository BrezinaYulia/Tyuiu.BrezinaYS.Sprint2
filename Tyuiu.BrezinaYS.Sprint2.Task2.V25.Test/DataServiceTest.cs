using Tyuiu.BrezinaYS.Sprint2.Task2.V25.Lib;
namespace Tyuiu.BrezinaYS.Sprint2.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}