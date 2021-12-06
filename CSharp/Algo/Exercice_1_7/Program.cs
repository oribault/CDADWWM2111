using System;

namespace Exercice_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Nombre a");
            a= int.Parse(Console.ReadLine());

            Console.Write("Nombre b");
            b = int.Parse(Console.ReadLine());


            if (a > b)
            {
                Console.WriteLine( a + " plus grand que " + b );
            }
            else
            {
                Console.WriteLine(a + " plus petit que " + b);
            }
        }
    }
}
