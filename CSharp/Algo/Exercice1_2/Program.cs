using System;

namespace Exercice1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double aire;
            double volume;

            aire = 4* Math.PI * r * r;

            volume = 4 / 3 * Math.PI * r * r * r;

            Console.WriteLine("La valeur de l'aire est de " + aire);
            Console.WriteLine("La valeur du volume est de " + volume);


        }
    }
}
