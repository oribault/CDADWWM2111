using System;

namespace Exercice_2_1_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double kilometers;
            double result;


            do
            {


                Console.WriteLine("Entrez une valeur en kilomètre ou appuyer sur q pour sortir");
                userInput = Console.ReadLine();
                if(userInput == "q")
                {
                       Environment.Exit(0);
                }

                kilometers = double.Parse(userInput);


                if (kilometers > 0.01 & kilometers < 1000000)
                {
                    result = kilometers / 1.609d;

                    Console.WriteLine("La valeur en mils est de " + result);
                }
                
                else
                {
                    Console.WriteLine("Saisir une nouvelle valeur");
                    userInput = Console.ReadLine();
                }
                


            } while (true);

        }
    }
}
