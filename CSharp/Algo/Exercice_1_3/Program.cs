using System;

namespace Exercice_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double a;
            double aire;

            Console.WriteLine("Entrer angle");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrer votre rayon");
            r = double.Parse(Console.ReadLine());
            aire = Math.PI * r * r * a / 360;
            Console.WriteLine("La valeur est de" + aire);



        }
    }
}
