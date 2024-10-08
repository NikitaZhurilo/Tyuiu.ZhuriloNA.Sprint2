using Tyuiu.ZhuriloNA.Sprint2.Task5.V6.Lib;
namespace Tyuiu.ZhuriloNA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value1 = 1;
            int value2 = 12;
            string res = ds.FindCardNameAndValue(value1, value2);
            Assert.AreEqual("Дама пик", res);
        }
    }
}