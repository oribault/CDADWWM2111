using System;

namespace Exercice_2._1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int n;
            int i;
            int somme;
            int number;

            Console.WriteLine("Entrer le nombre de nombre parfait");
            n = int.Parse(Console.ReadLine());
            number = 2;

            while(temp != n)
            {
               
                somme = 1;
                i = 2 + 1;
                while(i<=number / 2)
                {
                    if(number % i  == 0)
                    {
                        somme += i;
                        i++;
                        if(somme == number)
                            {
                            Console.WriteLine(number + "Est parfait");
                            temp++;  
                        }
                        
                    }
                    number++;
                }
                
            }
            
        }
    }
}
