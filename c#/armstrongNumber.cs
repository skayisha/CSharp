using System;

namespace Program {
    class ArmstrongNumber  {
        public static void Run() {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);
            int original = num, sum = 0;
            int digits = num.ToString().Length;

            while (num > 0) {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }

            Console.WriteLine(original == sum ? "Armstrong Number" : "Not Armstrong");

    }
}
}