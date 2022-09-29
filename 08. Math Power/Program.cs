using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            PoweringNumber(baseNumber,power);
        }

        static void PoweringNumber(double baseNumber, int power)
        {
            Console.WriteLine(Math.Pow(baseNumber, power));
        }
    }
}
