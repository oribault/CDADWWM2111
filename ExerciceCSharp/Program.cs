using System;

namespace Exercice_1_1_1
{
    public class Exercice1
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double moyenne;

            a = AskANumberToUser();
            b = AskANumberToUser();

            moyenne = CalculeMoyenne(a, b);
            AfficherResultat(moyenne);
            //Console.WriteLine(getdeCalculDeMoyenneDeDeuxNomnbres());
        }

        public static void AfficherResultat(double resultat)
        {
            Console.WriteLine(resultat);
        }

        public static double CalculeMoyenne(int nb1, int nb2)
        {
            return (((double)nb1 + (double)nb2) / 2d);
        }

        public static int AskANumberToUser()
        {
            bool  pasUnNombre;
            int nombre;
            do
            {
                Console.Write("Veuillez entrer un nombre entier : ");
                pasUnNombre = !(int.TryParse(Console.ReadLine(), out nombre));
            } while (pasUnNombre);
            return nombre;
        }

        public static int getdeCalculDeMoyenneDeDeuxNomnbres()
        {
            int nb1;
            int nb2;
            string[] myTab;
            string nb;
            int  result;

            Console.WriteLine("Saisissez deux nombres");
            nb = Console.ReadLine();

            myTab = nb.Split(" ");
            nb1 = int.Parse(myTab[0]);
            nb2= int.Parse(myTab[1]);
            result = (nb1 + nb2) / 2;

            return result;


          
        }
    }
}
