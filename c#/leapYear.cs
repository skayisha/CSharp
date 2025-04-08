using System;

namespace Program {
    class LeapYear  {
        public static void Run() {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine()!);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
                Console.WriteLine("Leap Year");
            } else {
                Console.WriteLine("Not a Leap Year");
            }
        }
    }
}
