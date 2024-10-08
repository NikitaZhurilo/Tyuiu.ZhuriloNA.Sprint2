using Tyuiu.ZhuriloNA.Sprint2.Task5.V6.Lib;
namespace Tyuiu.ZhuriloNA.Sprint2.Task5.V6
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
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #6                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет            *");
            Console.WriteLine("* требуемое значение и возвращает результат                                   *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int value1, value2;
            Console.WriteLine("Введите первое значение : ");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение : ");
            value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Ответ : {ds.FindCardNameAndValue(value1, value2)}");
            Console.ReadKey();

        }
    }
}
