using Tyuiu.BrezinaYS.Sprint2.Task5.V5.Lib;

namespace Tyuiu.BrezinaYS.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("��������", ds.FindCardValue(6));
            Assert.AreEqual("�������", ds.FindCardValue(7));
            Assert.AreEqual("���������", ds.FindCardValue(8));
            Assert.AreEqual("�������", ds.FindCardValue(9));
            Assert.AreEqual("�������",ds.FindCardValue(10));
            Assert.AreEqual("�����",ds.FindCardValue(11));
            Assert.AreEqual("����", ds.FindCardValue(12));
            Assert.AreEqual("������", ds.FindCardValue(13));
            Assert.AreEqual("���", ds.FindCardValue(14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(15);
            });���



        }
    }
}