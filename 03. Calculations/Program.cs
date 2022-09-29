using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculationType = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine()); 
            int numTwo = int.Parse(Console.ReadLine());

            switch (calculationType)
            {
                case "add":
                    Add(numOne, numTwo);
                    break;
                case "multiply":
                    Multiply(numOne, numTwo);
                    break;
                case "subtract":
                    Subtract(numOne, numTwo);
                    break;
                case "divide":
                    Divide(numOne, numTwo);
                    break;
            }
        }


        static void Add(int numOne, int numTwo)
        {
            Console.WriteLine(numOne + numTwo);
        }
         static void Multiply(int numOne, int numTwo)
        {
            Console.WriteLine(numOne * numTwo);
        }
        static void Subtract(int numOne, int numTwo)
        {
            Console.WriteLine(numOne - numTwo);
        }
        static void Divide(int numOne, int numTwo)
        {
            Console.WriteLine(numOne / numTwo);
        }
    }
}
