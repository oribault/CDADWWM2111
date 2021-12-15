using System;

namespace Exercice_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int q;
            bool O;
            double result;
            do
            {


                Console.WriteLine("Entrez un premier nombre");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Entrez un seconde nombre");
                b = int.Parse(Console.ReadLine());

                result = (a + b) / 2;
                Console.WriteLine("La valeur des nombres est " + result);

                Console.WriteLine("Souhaitez vous saisir un autre calcul ? 1:true / 0: false");

                q = int.Parse(Console.ReadLine());



                if (q == 0)
                {
                    O = false;
                }
                else
                {
                    O = true;
                }
            }while (O);


        }
    }
}
