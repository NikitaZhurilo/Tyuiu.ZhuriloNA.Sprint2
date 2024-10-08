using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZhuriloNA.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res = "";
            if (value1 == 1)
                switch (value2)
                {
                    case 6:
                        res = "Шестёрка пик";
                        break;
                    case 7:
                        res = "Семёрка пик";
                        break;
                    case 8:
                        res = "Восьмёрка пик";
                        break;
                    case 9:
                        res = "Девятка пик";
                        break;
                    case 10:
                        res = "Десятка пик";
                        break;
                    case 11:
                        res = "Валет пик";
                        break;
                    case 12:
                        res = "Дама пик";
                        break;
                    case 13:
                        res = "Король пик";
                        break;
                    case 14:
                        res = "Туз пик";
                        break;
                    default:
                        res = "Значения не соответствует, введите другие";
                        break;
                }
            else if (value1 == 2)
                switch (value2)
                {
                    case 6:
                        res = "Шестёрка треф";
                        break;
                    case 7:
                        res = "Семёрка треф";
                        break;
                    case 8:
                        res = "Восьмёрка треф";
                        break;
                    case 9:
                        res = "Девятка треф";
                        break;
                    case 10:
                        res = "Десятка треф";
                        break;
                    case 11:
                        res = "Валет треф";
                        break;
                    case 12:
                        res = "Дама треф";
                        break;
                    case 13:
                        res = "Король треф";
                        break;
                    case 14:
                        res = "Туз треф";
                        break;
                    default:
                        res = "Значения не соответствует, введите другие";
                        break;
                }
            else if (value1 == 3)
                switch (value2)
                {
                    case 6:
                        res = "Шестёрка бубен";
                        break;
                    case 7:
                        res = "Семёрка бубен";
                        break;
                    case 8:
                        res = "Восьмёрка бубен";
                        break;
                    case 9:
                        res = "Девятка бубен";
                        break;
                    case 10:
                        res = "Десятка бубен";
                        break;
                    case 11:
                        res = "Валет бубен";
                        break;
                    case 12:
                        res = "Дама бубен";
                        break;
                    case 13:
                        res = "Король бубен";
                        break;
                    case 14:
                        res = "Туз бубен";
                        break;
                    default:
                        res = "Значения не соответствует, введите другие";
                        break;
                }
            else if (value1 == 4)
                switch (value2)
                {
                    case 6:
                        res = "Шестёрка червей";
                        break;
                    case 7:
                        res = "Семёрка червей";
                        break;
                    case 8:
                        res = "Восьмёрка червей";
                        break;
                    case 9:
                        res = "Девятка червей";
                        break;
                    case 10:
                        res = "Десятка червей";
                        break;
                    case 11:
                        res = "Валет червей";
                        break;
                    case 12:
                        res = "Дама червей";
                        break;
                    case 13:
                        res = "Король червей";
                        break;
                    case 14:
                        res = "Туз червей";
                        break;
                    default:
                        res = "Значения не соответствует, введите другие";
                        break;
                }
            else
                res = "Значения не соответствует, введите другие";
            return res;
        }
    }
}
