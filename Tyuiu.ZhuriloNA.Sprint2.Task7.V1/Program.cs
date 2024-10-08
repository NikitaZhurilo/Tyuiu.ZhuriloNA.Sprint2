using Tyuiu.ZhuriloNA.Sprint2.Task7.V1.Lib;
namespace Tyuiu.ZhuriloNA.Sprint2.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Журило Н. А. | ИБКСб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #8                                                                  *");
            Console.WriteLine("* Вариант #1                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора   *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            double x, y;
            Console.WriteLine("Введите первое значение : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе значение : ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            if (ds.CheckDotInShadedArea(x, y))
                Console.WriteLine("Точка входит в закрашенную область");
            else
                Console.WriteLine("Точка не входит в закрашенную область");
            Console.ReadKey();
        }
    }
}
