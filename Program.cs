using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = Numbers.Fibonacci();

            fibonacci.ForEach(number => Console.WriteLine(number));

            Console.ReadLine();

            var isFibonacci = Numbers.IsFibonacci(55);
            var isFibonacci2 = Numbers.IsFibonacci(200);

            return;
        }
    }
}
