using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountBase discount = new RateDiscount();
            Console.WriteLine("The final discount is: "  + discount.GetPrice(100, 0.2m));

            DiscountBase discount2 = new AbsoluteDiscount();
            Console.WriteLine("The final discount is: " + discount2.GetPrice(100, 10m));

            Console.ReadKey();
        }
    }
}