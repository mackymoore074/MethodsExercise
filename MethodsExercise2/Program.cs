﻿


using System.Net.Cache;

public class Program
{
    public static int Addiction(int num1, int num2)
    {
        return num1 + num2;

    }
    public static int multiplication(int num1, int num2)
    {
        return num1 * num2;

    }
    public static int subtraction(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int division(int num1, int num2)
    {
        return num1 / num2;
    }

    public static void Main()
    {
        int answer1 = Addiction(2, 4);

        int answer2 = multiplication(10, 2);

        int answer3 = subtraction(10, 2);
        int answer4 = division(10, 2);

        Console.WriteLine(answer1);
        Console.WriteLine(answer2);
        Console.WriteLine(answer3);
        Console.WriteLine(answer4);
    }
}
