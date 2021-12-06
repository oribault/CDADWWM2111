using System;

namespace Exercice_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int temp;

            Console.WriteLine("Veuillez saisir un premier nombre");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un second nombre");
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + " est devenu "  + b);

        }
    }
}
