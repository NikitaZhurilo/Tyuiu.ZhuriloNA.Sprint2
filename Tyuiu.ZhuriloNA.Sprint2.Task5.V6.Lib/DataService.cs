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
                        res = "шестёрка пик";
                        break;
                    case 7:
                        res = "семёрка пик";
                        break;
                    case 8:
                        res = "восьмёрка пик";
                        break;
                    case 9:
                        res = "девятка пик";
                        break;
                    case 10:
                        res = "десятка пик";
                        break;
                    case 11:
                        res = "валет пик";
                        break;
                    case 12:
                        res = "дама пик";
                        break;
                    case 13:
                        res = "король пик";
                        break;
                    case 14:
                        res = "туз пик";
                        break;
                    default:
                        res = "значения не соответствует, введите другие";
                        break;
                }
            else if (value1 == 2)
                switch (value2)
                {
                    case 6:
                        res = "шестёрка треф";
                        break;
                    case 7:
                        res = "семёрка треф";
                        break;
                    case 8:
                        res = "восьмёрка треф";
                        break;
                    case 9:
                        res = "девятка треф";
                        break;
                    case 10:
                        res = "десятка треф";
                        break;
                    case 11:
                        res = "валет треф";
                        break;
                    case 12:
                        res = "дама треф";
                        break;
                    case 13:
                        res = "король треф";
                        break;
                    case 14:
                        res = "туз треф";
                        break;
                    default:
                        res = "значения не соответствует, введите другие";
                        break;
                }
            else if (value1 == 3)
                switch (value2)
                {
                    case 6:
                        res = "шестёрка бубен";
                        break;
                    case 7:
                        res = "семёрка бубен";
                        break;
                    case 8:
                        res = "восьмёрка бубен";
                        break;
                    case 9:
                        res = "девятка бубен";
                        break;
                    case 10:
                        res = "десятка бубен";
                        break;
                    case 11:
                        res = "валет бубен";
                        break;
                    case 12:
                        res = "дама бубен";
                        break;
                    case 13:
                        res = "король бубен";
                        break;
                    case 14:
                        res = "туз бубен";
                        break;
                    default:
                        res = "значения не соответствует, введите другие";
                        break;
                }
            else if (value1 == 4)
                switch (value2)
                {
                    case 6:
                        res = "шестёрка червей";
                        break;
                    case 7:
                        res = "семёрка червей";
                        break;
                    case 8:
                        res = "восьмёрка червей";
                        break;
                    case 9:
                        res = "девятка червей";
                        break;
                    case 10:
                        res = "десятка червей";
                        break;
                    case 11:
                        res = "валет червей";
                        break;
                    case 12:
                        res = "дама червей";
                        break;
                    case 13:
                        res = "король червей";
                        break;
                    case 14:
                        res = "туз червей";
                        break;
                    default:
                        res = "значения не соответствует, введите другие";
                        break;
                }
            else
                res = "значения не соответствует, введите другие";
            return res;
        }
    }
}
