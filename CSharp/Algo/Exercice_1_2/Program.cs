using System;

namespace Exercice_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double aire;
            double volume;

            Console.WriteLine("Entrer une valeur");
            r = int.Parse(Console.ReadLine());
            aire = 4 * Math.PI * r * r;
            Console.WriteLine("La valeur est " + aire);
            volume = 4 * Math.PI * r * r * r;
            Console.WriteLine("La valeur est " + volume);

        }
    }
}
