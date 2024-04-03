using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeArrays
{
    public static class ArrayService
    {
        public static int[] SetNumbersUntilTarget(int target)
        {
            int[] results = new int[target];

            for (int i = 0; i < target; i++)
            {
                Console.WriteLine("Input a Number:");
                _ = int.TryParse(Console.ReadLine(), out results[i]);
            }

            return results;
        }

        public static void SumArrayValues(int[] integers)
        {
            int sum = integers.Sum();
            Console.WriteLine($"The sum of this array equals to: {sum}");
        }

        public static void ArrayContainsTargetValue(int[] integers, int target)
        {
            var sevenMessage = integers.Contains(target) 
                ? "Hello, this int array does contain the number seven."
                : "Goodbye, this int array does NOT contain the number seven.";

            Console.WriteLine($"{sevenMessage}");
        }

        public static void SumEvenOddArrayValues(int[] integers)
        {
            int evenNumbers = integers.Where(c => c % 2 == 0).Count();
            int oddNumbers = integers.Where(c => c % 2 != 0).Count();

            Console.WriteLine($"This array contains: {evenNumbers} even numbers and {oddNumbers} odd numbers");
        }
    }
}
