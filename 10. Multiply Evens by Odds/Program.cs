using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            inputNumber = Math.Abs(inputNumber);

            int evenSum = GetSumOfEvenDigits(inputNumber);
            int oddSum = GetSumOfOddDigits(inputNumber);
            int totalResult = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(totalResult);
        }

       

        static int GetSumOfEvenDigits(int inputNumber)
        {
            int sumOfEven = 0;
            int digit = inputNumber;

            while (digit > 0)
            {
                int currDigit = digit % 10;
                if (currDigit % 2 == 0)
                {
                    sumOfEven += currDigit;
                }
                digit = digit / 10;  
            }
            return sumOfEven;
            
      
        }
         static int GetSumOfOddDigits(int inputNumber)
        {
            int sumOfOdd = 0;
            int digit = inputNumber;
            while (digit > 0)
            {
                int currentDigit = digit % 10;
                if (currentDigit % 2 != 0)
                {
                    sumOfOdd += currentDigit;
                }
                digit = digit / 10;

            }
            return sumOfOdd;

        }
        static int GetMultipleOfEvenAndOdds(int evenSum, int OddSum)
        {
            int result = evenSum * OddSum;
            return result;
        }
    }
}
