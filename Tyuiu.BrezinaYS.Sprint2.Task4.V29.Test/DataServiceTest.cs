using Tyuiu.BrezinaYS.Sprint2.Task4.V29.Lib;
namespace Tyuiu.BrezinaYS.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -7;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 106.286;
            Assert.AreEqual(wait, res);

        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = -2;
            Assert.AreEqual(wait, res);

        }
    }
}