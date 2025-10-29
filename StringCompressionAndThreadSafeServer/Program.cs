using System;
using Task1_Compression;
using Task2_ThreadSafeServer;
using System.Threading.Tasks;

namespace StringCompressionAndThreadSafeServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");

            string original = "aaabbcccdde";
            string compressed = StringCompressor.Compress(original);
            string decompressed = StringCompressor.Decompress(compressed);

            Console.WriteLine($"Исходная строка:  {original}");
            Console.WriteLine($"Сжатая строка:   {compressed}");
            Console.WriteLine($"Разжатая строка: {decompressed}");

            Console.WriteLine("\nЗадача 2");

            Parallel.For(0, 10, i =>
            {
                for (int j = 0; j < 1000; j++)
                    Server.AddToCount(1);
            });

            Console.WriteLine($"Ожидаемое значение: 10000");
            Console.WriteLine($"Фактическое значение: {Server.GetCount()}");
        }
    }
}
