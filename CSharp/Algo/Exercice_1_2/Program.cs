using System;

namespace Exercice_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rayon;
            double aire;
            double volume;

            Console.WriteLine("Entrer la valeur du rayon");

            rayon= int.Parse(Console.ReadLine());

            aire = 4 * Math.PI * Math.Pow( rayon,2);

            volume = 4 * Math.PI * Math.Pow(rayon, 3);

            Console.WriteLine(" La valeur de l'aire est " + aire);
            Console.WriteLine(" La valeur du volume1 est " + volume);



        }
    }
}
