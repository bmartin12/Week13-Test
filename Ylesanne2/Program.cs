using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\Kasutajakaust";
            string stars = "stars.txt";
            string planets = "planets.txt";
            string newFile = @$"{rootDirectory}\{stars}";
            string newFile1 = $@"{rootDirectory}\{planets}";
            bool directoryExists = File.Exists(newFile);
            if (directoryExists)
            {
                Console.WriteLine($"{stars} already exists.");
                Console.WriteLine($"{planets} already exists.");
            }
            else
            {
                File.Create(newFile);
                Console.WriteLine($"{stars} has been created");
                File.Create(newFile1);
                Console.WriteLine($"{planets} has been created");
            }
        }
    }
}
