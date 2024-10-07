using Tyuiu.ZhuriloNA.Sprint2.Task4.V12.Lib;
namespace Tyuiu.ZhuriloNA.Sprint2.Task4.V12
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
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #12                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                    *");
            Console.WriteLine("* с использованием тернарного оператора                                       *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            double x, y;
            Console.WriteLine("Введите x : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y : ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Ответ : {ds.Calculate(x, y)}");
            Console.ReadKey();
        }
    }
}
