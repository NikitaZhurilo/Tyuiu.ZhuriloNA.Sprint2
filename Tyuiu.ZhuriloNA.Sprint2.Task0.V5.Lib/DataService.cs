using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZhuriloNA.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = x == y;
            result[1] = x != y;
            result[2] = x < y;
            result[3] = x + 200 > y;
            result[4] = x + 200 <= y;
            result[5] = x + 200 >= y;
            return result;
        }
    }
}
