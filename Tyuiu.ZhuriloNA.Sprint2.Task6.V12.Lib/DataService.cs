using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZhuriloNA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 => 31,
                2 => 29,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new ArgumentOutOfRangeException("Некорректный месяц")
            };
            if (m < 1 || m > 12 || n < 1 || n > daysInMonth)
            {
                throw new ArgumentOutOfRangeException("Некорректная дата");
            }
            if (n > 1)
            {
                return ($"0{n - 1}.0{m}.{g}"); 
            }
            else
            {
                if (m == 1)
                {
                    return ($"{31}.{12}.{g - 1}"); 
                }
                else
                {
                    return ($"0{daysInMonth}.0{m - 1}.{g}"); 
                }
            }
        }
    }
}
