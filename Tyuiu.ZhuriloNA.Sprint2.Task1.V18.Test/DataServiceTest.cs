using Tyuiu.ZhuriloNA.Sprint2.Task1.V18.Lib;
namespace Tyuiu.ZhuriloNA.Sprint2.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 155;
            int b = 696;
            int c = 242;
            int d = 541;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] ret = new bool[6] { true, true, true, false, true, false };
            CollectionAssert.AreEqual(res, ret);
        }
    }
}