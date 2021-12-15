using System;

namespace Exercice_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] numbers;
            String saisie;
            double average = 0;

            Console.WriteLine("Saisissez des nombre séparé par espace");
            saisie = Console.ReadLine();
            numbers = saisie.Split(" ");

            for( int i = 0; i < numbers.Length; i++) 
            {
                average = average + int.Parse(numbers[i]);
            }

            Console.WriteLine("La moyenne des nombres est de" + (average / numbers.Length));

        }
    }
}
