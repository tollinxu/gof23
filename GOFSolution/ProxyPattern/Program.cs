using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gilr = new SchoolGirl("Anita");

            var proxy = new Proxy("proxy", gilr);

            proxy.SendFlower();

            Console.ReadKey();
        }
    }
}