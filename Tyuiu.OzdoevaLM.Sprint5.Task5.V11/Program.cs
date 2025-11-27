
using System.IO;
using Tyuiu.OzdoevaLM.Sprint5.Task5.V11.Lib;
namespace Tyuiu.OzdoevaLM.Sprint5.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5| Выполнила: Оздоева Л.М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Оздоева Л.М. | ИИПб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти произведение всех нечетных целых чисел в файле.вывести на консоль.*");
            Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль.                *");
            Console.WriteLine("* Округлить до трёх знаков после запятой                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask5V11.txt");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("произведение всех нечетных целых чисел в файле: " + res);
            Console.ReadKey();
        }
    }
}