using System;
using System.IO;

namespace ChuckNorrisJokes
{
    class Program
    {
        static void Main(string[] args)
        {


            //string filePath = @"C:\Users\opilane\samples\Chuck.txt";
            //string[] jokeAboutChuck = File.ReadAllLines(filePath);


            //Random rnd = new Random();
            //int randomIndex = rnd.Next(0, jokeAboutChuck.Length);
            //Console.WriteLine(jokeAboutChuck[randomIndex]);

            Console.WriteLine(GetRandomJokje());

        }
        public static string GetRandomJokje()
        {
            string filePath = @"C:\Users\opilane\samples\Chuck.txt";
            string[] jokeAboutChuck = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, jokeAboutChuck.Length);

            return jokeAboutChuck[randomIndex];
        }
    }
}
