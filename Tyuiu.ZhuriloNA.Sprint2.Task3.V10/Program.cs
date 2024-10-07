using Tyuiu.ZhuriloNA.Sprint2.Task3.V10.Lib;
namespace Tyuiu.ZhuriloNA.Sprint2.Task3.V10
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
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #10                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и    *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области    *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            double x;
            Console.WriteLine("Введите x : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Ответ : {ds.Calculate(x)}");
            Console.ReadKey();
        }
    }
}
