using System;

namespace Exercice_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreDeLutilisateur;
            int nombreDeLordinateur;

            Console.WriteLine("Choisir un nombre entre 0 1 et 3");
            nombreDeLutilisateur = int.Parse(Console.ReadLine());

            Random rand = new Random();

            nombreDeLordinateur = rand.Next(0, 3);
        }
    }
}
