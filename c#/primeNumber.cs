using System;

namespace Program {
    class PrimeNumber {
        public static void Run() {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (num < 2) isPrime = false;
            else {
                for (int i = 2; i <= Math.Sqrt(num); i++) {
                    if (num % i == 0) {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPrime ? "Prime Number" : "Not Prime");
        }
    }
}
