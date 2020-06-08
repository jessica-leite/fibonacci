using System.Collections.Generic;

namespace Fibonacci
{
    public class Numbers
    {
        public static List<int> Fibonacci()
        {
            int previousNumber = 0, currentNumber = 1;

            var numbers = new List<int> { previousNumber, currentNumber };

            while (previousNumber + currentNumber <= 350)
            {
                var newNumber = previousNumber + currentNumber;

                numbers.Add(newNumber);

                previousNumber = currentNumber;
                currentNumber = newNumber;
            }

            return numbers;
        }

        public static bool IsFibonacci(int number)
        {
            var sequence = Fibonacci();

            return sequence.Contains(number);
        }
    }
}
