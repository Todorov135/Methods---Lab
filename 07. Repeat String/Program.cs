using System;

namespace _07.Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a  = Console.ReadLine();
           int b = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatingString(a,b));
        }

         static string RepeatingString(string a, int b)
        {
            string sumOfStrings = "";
            for (int i = 0; i < b; i++)
            {
                sumOfStrings += a;
            }
            return sumOfStrings;
             
        }
    }
}
