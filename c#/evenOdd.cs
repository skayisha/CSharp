using System;

namespace Program {
    class EvenOdd {
        public static void Run() {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
    }
}
}