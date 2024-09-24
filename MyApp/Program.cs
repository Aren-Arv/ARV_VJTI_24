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
            long factorial = FactorialRecursive(number);
            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }
    }

    static long FactorialRecursive(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * FactorialRecursive(n - 1);
    }
}