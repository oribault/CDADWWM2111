using System;

namespace Exercice2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            string[] tabSaisie;


            Console.WriteLine("Saisir une vaveur et son unité de mesure (séparés par un espace) : ");
            saisie = Console.ReadLine();

            tabSaisie = saisie.Split("");

            if(tabSaisie.Length < 2)
            {
                Console.WriteLine("La valeur en mi donne" + double.Parse(tabSaisie[0])/1.609 + "miles");
            }
            else if (tabSaisie[1] == "mi")
            {
                Console.WriteLine("la valeur en km donne " + double.Parse(tabSaisie[0]) * 1.609 + " km");
            }
            else
            {
                Console.WriteLine("la valeur en mi donne " + double.Parse(tabSaisie[0]) / 1.609 + " miles");
            }
        }
    }
}
