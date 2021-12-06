using System;

namespace Exercice_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace Exercice_1_8
    {
        class Program
        {
            private static object mod;

            static void Main(string[] args)
            {
                int a;
                int divisor;
                int number;

                Console.WriteLine("Entrez une année");
                a = int.Parse(Console.ReadLine());

                if (a % 4 != 0)
                {
                    Console.WriteLine("Lannée n' est pas bisextile");
                }
                else
                {
                    if (a % 100 == 0 && a % 400 != 0)
                    {
                        Console.WriteLine("Lannée n' est pas bisextile");
                    }
                    else
                    {
                        Console.WriteLine("Lannée est  bisextile");

                        for (divisor = 2; divisor <= number - 1; divisor++)
                        {
                            if (number % divisor == 0)
                            {
                                a = false;
                            }
                        }
                        if (a)
                        {
                            Console.WriteLine("The number is preime");
                        }
                        else
                        {
                            Console.WriteLine("The number is  not preime");
                        }

                    }
                }








            }
        }
    }

}
    }
}
