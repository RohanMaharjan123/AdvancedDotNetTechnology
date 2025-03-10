using System;

class Program
{
    static void Main()
    {
        int number;
        while (true)
        {
            Console.Write("Enter a number: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out number) && number > 0)
            {
                break; // Exit loop if a valid positive integer is entered
            }
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            int largestFactor = LargestFactor(number);
            Console.WriteLine($"{number} is not a prime number. The largest factor is {largestFactor}.");
        }
    }

    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Function to find the largest factor of the number
    static int LargestFactor(int number)
    {
        for (int i = number / 2; i >= 1; i--)
        {
            if (number % i == 0)
                return i;
        }
        return 1; // This will never be reached since 1 is always a factor.
    }
}