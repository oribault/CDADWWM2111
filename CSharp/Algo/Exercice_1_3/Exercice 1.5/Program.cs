using System;

namespace Exercice_1._5
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

            Console.WriteLine("Ecrire la somme de la valeur initiale");
            S = double.Parse(Console.ReadLine());

            Console.WriteLine("Ecrire la somme de la valeur de l'intérêt ");
            I = double.Parse(Console.ReadLine());

            Console.WriteLine("Ecrire la somme de la valeur du nombre d'années  ");
            N  = double.Parse(Console.ReadLine());

            IS = S*(1 + N * I)-S;
            Console.WriteLine("L'intérêt simple est de " + IS);

            IC = S* Math.Pow(1+I,N)-S;
            Console.WriteLine("L'intérêt composé est de " + IC);


        }
    }
}
