using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("please input number 1!");
                var number1 = Console.ReadLine();

                Console.WriteLine("please input number 2!");
                var number2 = Console.ReadLine();

                Console.WriteLine("please input the operator!");
                var optor = Console.ReadLine();

                var caculate = SimpleFactory.GetOperation(optor);
                caculate.OperationNumberA = int.Parse(number1);
                caculate.OperationNumberB = int.Parse(number2);
                var result = caculate.GetResult();
                Console.WriteLine($"number:{number1} {optor} number:{number2} result is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"unknow exception: {ex.Message}");
            }
            Console.WriteLine("press any key to terminate this console ....");
            Console.ReadKey();
        }
    }
}