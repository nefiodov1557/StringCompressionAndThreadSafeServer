using System;
using System.Threading.Tasks;
using Task2_ThreadSafeServer;

namespace ServerTestApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Тест параллельной записи и чтения...");

            Parallel.For(0, 10, i =>
            {
                for (int j = 0; j < 1000; j++)
                    Server.AddToCount(1);
            });

            // Проверим результат
            Console.WriteLine($"Ожидаемое значение: 10000");
            Console.WriteLine($"Фактическое значение: {Server.GetCount()}");

            Console.WriteLine("\nТест завершён!");
        }
    }
}
