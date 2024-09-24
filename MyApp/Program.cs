using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a non-negative integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            long factorial = FactorialIterative(number);
            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }
    }

    static long FactorialIterative(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}