using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("please input the roomtype Id you want to checkin, they are include [DC, CDC, BJ, SBC, SCF]");
                var roomtype = Console.ReadLine();

                Console.WriteLine("please input the price strategry type, they are [activityPattern, discountPattern]");
                var priceStrategy = Console.ReadLine();

                Console.WriteLine("we are caculating your room price for you....");
                var priceService = new PriceService(priceStrategy);

                var price = priceService.GetPrice(roomtype, DateTime.Today);

                Console.WriteLine($"your room price is {price}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"unkown excetpion occur, message:{ex.Message}");
            }
            

            Console.WriteLine("press any key to terminate your console.....");
            Console.ReadKey();
        }
    }
}