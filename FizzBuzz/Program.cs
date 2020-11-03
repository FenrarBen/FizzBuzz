using System;

namespace FizzBuzz
{
    class Program
    {
        // Takes an array of ints and checks each element for divisability by 3 and/or 5
        static void FizzBuzz(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 0 && arr[i] % 3 == 0)
                {
                    Console.WriteLine($"Element {arr[i]}\t at location {i} is: FizzBuzz");
                }
                else if (arr[i] % 5 == 0)
                {
                    Console.WriteLine($"Element {arr[i]}\t at location {i} is: Buzz");
                }
                else if (arr[i] % 3 == 0)
                {
                    Console.WriteLine($"Element {arr[i]}\t at location {i} is: Fizz");
                }
                else
                {
                    Console.WriteLine($"Element {arr[i]}\t at location {i} isn't divisable by 3 or 5");
                }
            }
        }

        // Takes an int to set a range (1 - num), and checks each int in that range
        static void FizzBuzz(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                string fizzBuzz = "";
                if (i % 3 == 0)
                {
                    fizzBuzz += "Fizz";
                }
                if (i % 5 == 0) 
                {
                    fizzBuzz += "Buzz";
                }
                if (fizzBuzz != "")
                {
                    Console.Write($"The number {i} is: ");
                    Console.WriteLine(fizzBuzz);
                }
            }
        }

        // Takes in an int and checks only that int for divisability by 3 and/or 5
        static void FizzSelect(int num)
        {
            if ((num % 5 == 0) && (num % 3 == 0))
            {
                Console.WriteLine($"The number {num} is: FizzBuzz");
            } 
            else if (num % 5 == 0)
            {
                Console.WriteLine($"The number {num} is: Buzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"The number {num} is: Fizz");
            }
            else
            {
                Console.WriteLine("That number does not fizz, nor does it buzz");
            }
        }

        static void Main(string[] args)
        {
            // Input num to specify range
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            FizzBuzz(num);

            // Input num to check only that number
            Console.WriteLine("Enter a specific number to FizzBuzz");
            num = Convert.ToInt32(Console.ReadLine());
            FizzSelect(num);

            // Create an array of 20 random ints to check
            Random rnd = new Random();
            int[] intArray = new int[20];
            for (int i = 0; i < 20; i++)
            {
                intArray[i] = rnd.Next(1, 1000);
            }
            FizzBuzz(intArray);

            // We're FizzBuzzin' now baby!
        }
    }
}
