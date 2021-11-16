using System;
using System.IO;

namespace BlackSheep
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples\Blacksheep.txt";
            string[] dataFormFile = File.ReadAllLines(filePath);
            
            for(int i = 0; i < dataFormFile.Length; i++)
            {
                dataFormFile[i] = dataFormFile[i].Replace('4', 'a');
                dataFormFile[i] = dataFormFile[i].Replace('3', 'e');
                dataFormFile[i] = dataFormFile[i].Replace('0', 'o');
                dataFormFile[i] = dataFormFile[i].Replace('1', 'i');
                

            }
            foreach(string line in dataFormFile)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(filePath, dataFormFile);

        }
    }
}
