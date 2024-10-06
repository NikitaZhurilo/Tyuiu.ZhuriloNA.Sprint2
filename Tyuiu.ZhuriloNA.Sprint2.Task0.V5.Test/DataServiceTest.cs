using Tyuiu.ZhuriloNA.Sprint2.Task0.V5.Lib;
namespace Tyuiu.ZhuriloNA.Sprint2.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 223;
            bool[] z = new bool[6]; 
            z = ds.GetCompareOperations(x, y);
            bool[] res = new bool[6] { false, true, true, true, false, true };
            CollectionAssert.AreEqual(z, res);
        }
    }
}