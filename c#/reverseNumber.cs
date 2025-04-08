using System;

namespace Program {
    class ReverseNumber {
        public static void Run() {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;

            while (num > 0) {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num /= 10;
            }

            Console.WriteLine("Reversed number: " + reverse);
        }
    }
}
