using System.ComponentModel;
using System;
using System.Drawing;
using static System.Formats.Asn1.AsnWriter;
using System.Dynamic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); // output
            var name = Console.ReadLine(); // input
            Console.WriteLine($" My Name is {name}");
            Console.WriteLine("What is your Favorite Color?"); // output
            var FavoriteColor = Console.ReadLine(); // input
            Console.WriteLine($" My Favorite Color is {FavoriteColor}");
            Console.WriteLine("What is your Favorite Animal?"); // output
            var FavoriteAnimal = Console.ReadLine(); // input
            Console.WriteLine($" My Favorite Animal is {FavoriteAnimal}");
            Console.WriteLine("What is your Favorite Band?"); // output
            var FavoriteBand = Console.ReadLine(); // input
            Console.WriteLine($" My Favorite Band is {FavoriteBand}");

            Console.WriteLine($"My dog's name is {name}. The color of his fur is {FavoriteColor}.My Favorite Animal is {FavoriteAnimal}" +
            $" My Favorite Band is {FavoriteBand}");
        }

    }
}



public class Math
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    public static int Divide(int num1, int num2)
    {
        return num1 / num2;
    }
    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
