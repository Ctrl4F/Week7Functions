using System;

namespace FunctionsReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth:");
            string userInput = Console.ReadLine();
            int userAge = CalculateAge(userInput);
            ValidateAge(userAge);

            //Console.WriteLine($"You were born in the year {userAge}.");
        }

        public static int CalculateAge(string userInput)
        {
            int userAge = 2020 - Int32.Parse(userInput);
            return userAge;
        }
        public static void ValidateAge(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("You are not old enough to drive a car.");
            }
            else
            {
                Console.WriteLine("Go get it");
            }
        }
    }
}
