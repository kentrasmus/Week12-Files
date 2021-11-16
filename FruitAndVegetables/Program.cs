using System;
using System.IO;

namespace FruitAndVegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fruitPath = @"C:\Users\opilane\samples\Fruit.txt";
            string[] veggieData = File.ReadAllLines(fruitPath);

            string VeggiePath = @"C:\Users\opilane\samples\Veggie.txt";
            string[]fruitData = File.ReadAllLines(VeggiePath);

            File.WriteAllLines(fruitPath, fruitData);

            File.WriteAllLines(VeggiePath, veggieData);
        }
    }
}
