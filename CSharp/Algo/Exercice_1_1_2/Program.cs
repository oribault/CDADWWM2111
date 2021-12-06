using System;

namespace Exercice_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1;
            int nb2;
            double result;
            bool redo;
            string answerForRedo = "null";
            String O = "Oui";
            String N;

            do
            {
                Console.WriteLine("Enter a first number ");
                nb1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number ");
                nb2 = int.Parse(Console.ReadLine());

                result = (nb1 + nb2) / 2;
                Console.WriteLine($"The average of the two number is {result}");
                Console.WriteLine("Souhaitez-vous faire un nouveau calcul ? ");
                answerForRedo = Console.ReadLine();
                if (answerForRedo == "O")
                {
                    Console.Write("Saisissez un autre calcul");
                    redo = true;
                    
                }
                else
                {
                    Console.Write("Fin du programme");
                    redo = false;
                }

            } while (redo);
        }
    }
}
