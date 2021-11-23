using System;
using System.IO;
namespace Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string rootPath = @"C:\Users\opilane\samples";
            Console.WriteLine("Sisesta kausta nimi");
            string kasutajaKaust = Convert.ToString(Console.ReadLine());
            string createDirectory = $@"{rootPath}\{kasutajaKaust}";

            bool directoryExists = Directory.Exists(createDirectory);

            if (directoryExists)
            {
                Console.WriteLine($"Kaust {kasutajaKaust} on juba olemas samples kaustas");
            }
            else
            {
                Console.WriteLine($"Kaust {kasutajaKaust} on loodud");
                Directory.CreateDirectory(createDirectory);

            }
        }
    }
}
