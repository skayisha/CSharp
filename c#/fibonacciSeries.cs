using System;

namespace Program {
    class FibonacciSeries {
        public static void Run() {
            Console.Write("Enter the count: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1;

            Console.Write("Fibonacci: ");
            for (int i = 0; i < n; i++) {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}
