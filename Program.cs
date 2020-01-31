using System;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(productPrice: 14.14);

            PrintMaxDiscount(product); // Product Discount is 5,65
            PrintMinDiscount(product); // Product Discount is 12,72
        }


        static void PrintMaxDiscount(IMaximumDiscount maximumDiscount)
        {
            Console.WriteLine($"Product Discount is {maximumDiscount.GetDiscount()}");
        }


        static void PrintMinDiscount(IMinimumDiscount minimumDiscount)
        {
            Console.WriteLine($"Product Discount is {minimumDiscount.GetDiscount()}");
        }
    }
}
