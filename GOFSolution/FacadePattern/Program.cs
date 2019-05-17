using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new FacadeUtility();
            facade.NightAudit();

            Console.WriteLine("press any key to terminate program ....");
            Console.ReadKey();
        }
    }
}