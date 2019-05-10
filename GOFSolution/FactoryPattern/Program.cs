using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generator Good Things");
            IFactory factory = new VolunteerFactory();
            var goodThings = factory.CreateGoodThings();
            goodThings.DoingGoodthings();
            Console.WriteLine("press any key to terminate process...");
            Console.ReadKey();
        }
    }
}