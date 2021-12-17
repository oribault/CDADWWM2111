using System;

namespace Exercice1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcul de la moyenne de 2 nombres");
            int a;
            int b;
            double result;

            Console.WriteLine("Entrer un premier nombre entier");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrer un premier nombre entier");
            b = int.Parse(Console.ReadLine());

            result = (a + b) / 2;
            Console.WriteLine("La valaur des deux nombres est de " + result);

        }
    }
}
