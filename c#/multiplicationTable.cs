using System;

namespace Program {
    class MultiplicationTable  {
        public static void Run() {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
