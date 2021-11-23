using System;
using System.Collections.Generic;
using System.IO;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirect = @$"C:\Users\opilane\samples\Kasutajakaust";

            string[] dataFormFile = File.ReadAllLines($@"{rootDirect}\MilkyWay.txt");
            List<string> planet = new List<string>();
            List<string> stars = new List<string>();

            for (int i = 0; i < dataFormFile.Length; i++)
            {
                if (dataFormFile[i].Contains("planets"))
                {
                    planet.Add(dataFormFile[i]);
                }
                else if (dataFormFile[i].Contains("stars"))
                {
                    stars.Add(dataFormFile[i]);
                }
            }

            File.WriteAllLines($@"{rootDirect}\planets.txt", planet);
            File.WriteAllLines($@"{rootDirect}\stars.txt", stars);


        }
    }
}
