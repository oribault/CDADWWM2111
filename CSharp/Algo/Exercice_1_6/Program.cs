using System;

namespace Exercice_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int divisor;
            bool isPrime;

            isPrime = true;
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());

            for (divisor = 2; divisor <= number - 1; divisor++)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("The number is preime");
            }
            else
            {
                Console.WriteLine("The number is  not preime");
            }
        }
    }
}
