using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var felix = new Resume("felix");
            felix.Age = 30;
            felix.University = "Shandong University";

            var anita = (Resume)felix.Clone();
            anita.Name = "Anita";

            Console.WriteLine(felix);
            Console.WriteLine(anita);

            Console.ReadKey();
        }
    }
}