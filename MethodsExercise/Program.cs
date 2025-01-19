﻿namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! what is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("what is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();
            
            Console.WriteLine($"One day, {userName} was walking through the wood while wearing a {favColor} t-shirt. {userName} saw a {favAnimal} listening to {favBand}");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Substract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int Sum = 0;

            foreach (int number in numbers)
            {
                Sum += number;
            }

            return Sum;

        }
        
        static void Main(string[] args)
        {
            Madlib();
            Console. WriteLine(Add(numOne:2, numTwo:3));
            int addednums = Add(numOne:2, numTwo:3);
            Console.WriteLine(addednums);
            Console. WriteLine(Substract(numOne:2, numTwo:3));
            Console.WriteLine(multiply(numOne: 2, numTwo: 3));
            Console.WriteLine(Divide(numOne: 2, numTwo: 3));
            Console.WriteLine(Sum(5,5,5,5,5,5,5,5,5));
        }
    }
}
