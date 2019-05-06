using System;

namespace DecorationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Felix");

            var tshirt = new TShirt();
            tshirt.SetDecorator(p);

            var big = new BigTrouser();
            big.SetDecorator(tshirt);

            big.Show();

            Console.ReadKey();
        }
    }
}