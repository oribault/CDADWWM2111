using System;

namespace Exercice_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double S;
            double I;
            double N;
            double IS;
            double IC;

            Console.WriteLine("Ecrire la valeur de la somme initiale");
            S = int.Parse(Console.ReadLine());

            Console.WriteLine("Ecrire la valeur de l'intérêt");
            I = int.Parse(Console.ReadLine());

            Console.WriteLine("Ecrire la valeur du nombre d'année");
            N = int.Parse(Console.ReadLine());

            IS = S * (1 + N * I) - S;
            Console.WriteLine("La valeur de d'intérêt est est " + IS);

            IC = S * (1 + N * I) - S;
            Console.WriteLine("La valeur de d'intérêt composé est " + IC);

        }
    }
}
