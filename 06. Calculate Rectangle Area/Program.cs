using System;

namespace _06.Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double area = CalculateRectangle(sideA, sideB);
            Console.WriteLine(area);
        }

         static double CalculateRectangle(double sideA, double sideB)
        {
            return sideA * sideB;
        }
    }
    
}
