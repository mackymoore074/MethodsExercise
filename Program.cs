using System;
class Program
{
    static void Main(string[] args)
    {
        // calls to the methods
        Console.WriteLine(Sum(2, 4)); 
        Console.WriteLine(Subtract(10, 2)); 
        Console.WriteLine(Multiply(10, 2)); 
        Console.WriteLine(Divide(10, 2)); 
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }
}
