using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZhuriloNA.Sprint2.Task3.V10.Lib
{
    public class DataService : ISprint2Task3V10
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 0)
            {
                y = x - Math.Pow(((x + 15) / (x - 4)), x);
            }
            else if (x == 0)
            {
                y = (x * x + Math.Cos(x * x) - 3) / (x * x - Math.Sin(x * x) + 2);
            }
            else if (x < -14)
            {
                y = x + 10 * x - (1 / x);
            }
            else
            {
                y = Math.Pow(5 + (1 / x * x), x);
            }
            return Math.Round(y, 3);
        }
    }
}
