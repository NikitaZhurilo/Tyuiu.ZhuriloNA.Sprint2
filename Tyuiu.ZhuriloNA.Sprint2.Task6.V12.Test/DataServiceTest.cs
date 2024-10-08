using Tyuiu.ZhuriloNA.Sprint2.Task6.V12.Lib;
namespace Tyuiu.ZhuriloNA.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 12;
            int n = 25;
            var res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(res, );

        }
    }
}