using System;

namespace Exercice_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int divisor;
            bool isPrime;

            isPrime = true;

            Console.WriteLine("Entrer un nombre ");
            number = int.Parse(Console.ReadLine());

            for (divisor = 2; divisor < number -1; divisor ++) 
            {
                if(number % divisor == 0)
                {
                    isPrime = false;
                }

            }
            if (isPrime)
            {
                Console.WriteLine("Le nombre est premier");
            }
            else
            {
                Console.WriteLine("Le nombre n'est pas premier");
            }
        }
    }
}
