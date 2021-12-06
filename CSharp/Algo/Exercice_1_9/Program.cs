using System;

namespace Exercice_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int i;

            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());

            for (i = 2; i< number; i++)
            {
                if((number % i) == 0)
                {
                    Console.WriteLine(i);
                }
            }

           
        }
    }
}
