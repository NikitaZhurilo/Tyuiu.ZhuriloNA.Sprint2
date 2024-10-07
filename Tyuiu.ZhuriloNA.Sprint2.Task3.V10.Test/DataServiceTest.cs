using Tyuiu.ZhuriloNA.Sprint2.Task3.V10.Lib;
namespace Tyuiu.ZhuriloNA.Sprint2.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            Assert.AreEqual(-3199995, res);
        }
    }
}