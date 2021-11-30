using System;

namespace Exercice_1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1;
            int nb2;
            double result;

            Console.Write("Enter a first number");
            nb1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a second number");
            nb2 = int.Parse(Console.ReadLine());

            result = (int)nb1 + (int)nb2 / 2d;
            Console.WriteLine("Le resultau de la moyenne est de " + result);
        }
    }
}
