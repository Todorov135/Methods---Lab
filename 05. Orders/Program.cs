using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orther = Console.ReadLine();
            int ortherQuantity = int.Parse(Console.ReadLine());
            double price = 0;
            switch (orther)
            {
                case "coffee":
                    price = 1.50;
                    OrtherPrice(ortherQuantity, price);
                    break;
                case "water":
                    price = 1.00;
                    OrtherPrice(ortherQuantity, price);
                    break;
                case "coke":
                    price = 1.40;
                    OrtherPrice(ortherQuantity, price);
                    break;
                case "snacks":
                    price = 2.00;
                    OrtherPrice(ortherQuantity, price);
                    break;

            }
        }

         static void OrtherPrice(int ortherQuantity, double price)
        {
            Console.WriteLine($"{(ortherQuantity * price):f2}");
        }
    }
}
