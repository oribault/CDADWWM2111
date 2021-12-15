using System;

namespace Exercice_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double result;

            Console.WriteLine("Entrer un premier nombre");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer un second nombre");
            b = int.Parse(Console.ReadLine());

            result = (a + b) / 2;
            Console.WriteLine("La valeur est de " + result);
            
        }
    }
}
