using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZhuriloNA.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((x * x + y * y <= 1) && (y >= Math.Abs(x)) && (x * x + y * y >= 0))
                return true;
            return false;
        }
    }
}
