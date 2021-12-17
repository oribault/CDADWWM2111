using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int q = 1;
            double result;

            do
            {
                Console.WriteLine("Calcul de la moyenne de 2 nombres");


                Console.WriteLine("Entrer un premier nombre entier");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Entrer un premier nombre entier");
                b = int.Parse(Console.ReadLine());

                result = (a + b) / 2;
                Console.WriteLine("La valaur des deux nombres est de " + result);

                Console.WriteLine("Voulez-vous effectuer un autre calcul ? (1 : true 0 = false ");
                q = int.Parse(Console.ReadLine());



            } while (q == 1);
        }
    }
}
