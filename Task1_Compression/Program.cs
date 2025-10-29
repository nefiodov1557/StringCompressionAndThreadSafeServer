using System;
using Task1_Compression;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "aaabbcccdde";
            string compressed = StringCompressor.Compress(original);
            string decompressed = StringCompressor.Decompress(compressed);

            Console.WriteLine($"Исходная строка: {original}");
            Console.WriteLine($"Сжатая строка:  {compressed}");
            Console.WriteLine($"Разжатая строка: {decompressed}");
        }
    }
}
