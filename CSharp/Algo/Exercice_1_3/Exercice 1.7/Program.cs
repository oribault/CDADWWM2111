using System;

namespace Exercice_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Entrer un nombre a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrer un nombre b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrer un nombre c");
            c = int.Parse(Console.ReadLine());

            if (a < b)
            {
                if (c < a)
                {
                    Console.WriteLine(c + " plus petit que " + a + " plus petit que " + b);
                }
                else
                {
                    if (c < b)
                    {
                        Console.WriteLine(a + " plus petit que " + c + " plus petit que " + b);
                    }
                    else
                    {
                        Console.WriteLine(a + " plus petit que " + b + "PLUS PETIT QUE " + c);
                    }
                }
            }
            else
            {
                if (c < b)
                {
                    Console.WriteLine(c + " plus petit que" + b + "plus petit que" + a)
                }
                else
                {
                    if (c < a)
                    {
                        Console.WriteLine(b + " plus petit que" + c + "plus petit que " + a);
                    }
                    else
                    {
                        Console.WriteLine(b + "plud petit que" + a + "plus petit que" + c);
                    }
                }
            }

        };
