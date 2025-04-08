using System;

namespace Program {
    class SumOfDigits  {
        public static void Run() {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);
            int sum = 0;

            while (num > 0) {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}
