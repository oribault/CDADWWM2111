using System;

namespace Exercice_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int n;
            int i;
            int somme;
            int number;

            Console.WriteLine("Enter the number perfect");
            n = int.Parse(Console.ReadLine());

            number = 2;
            while (temp != n)
            {
                somme = 0;
                for (i = 1; i < number;  i++) 
                {
                    if (number % i == 0)
                    {
                        somme += i;
                    }
                }
                if (somme == number)
                {
                            
                   Console.WriteLine(number + "est un nombre parfait");
                   temp++;
                }
                number++;
            }
        }   

    }
}
