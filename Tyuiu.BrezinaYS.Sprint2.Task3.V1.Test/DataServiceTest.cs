using Tyuiu.BrezinaYS.Sprint2.Task3.V1.Lib;

namespace Tyuiu.BrezinaYS.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditional1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = -8.741;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidConditional2()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -21.698;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditional3()
        {
            DataService ds = new DataService();
            double x = -4;
            double res = ds.Calculate(x);
            double wait = -43.75;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditional4()
        {
            DataService ds = new DataService();
            double x = -6;
            double res = ds.Calculate(x);
            double wait = -65.995;
            Assert.AreEqual(wait, res);
        }
    }
}