using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random facts so interesting you'll say, OMG!");
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(RandomLineFromFile());
            }
        }
        private static string RandomLineFromFile()
        {

            string filePath = @"C:\Users\opilane\samples\Kasutajakaust\funFacts.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, dataFromFile.Length);
            return dataFromFile[randomIndex];
        }
    }
}
