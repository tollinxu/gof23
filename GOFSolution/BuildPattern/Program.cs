using System;

namespace BuildPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountCache = new AccountCache();
            Builder.BuildCache(accountCache);

            var priceCache = new PriceDetailCache();
            Builder.BuildCache(accountCache);

            Console.WriteLine("Press any key to terminate program ...");
            Console.ReadKey();
        }
    }
}