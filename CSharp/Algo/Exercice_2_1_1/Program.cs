using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercice_2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            tring userInput;
            double kilometers;
            do
            {
                Console.WriteLine("Enter a distance in kilometers to convert it to miles or press 'q' to quit");
                userInput = Console.ReadLine();
                if (userInput.Equals("q"))
                {
                    Console.WriteLine("Bye bye");
                    Environment.Exit(0);
                }
                else
                {
                    if (CheckIsNumber(userInput, out kilometers))
                    {
                        if (kilometers > 0.01d && kilometers < 1000000d)
                        {
                            Console.WriteLine($"{kilometers} kilometers are equal to {ConvertKilometersToMiles(kilometers)} miles");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Input\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input\n");
                    }
                }
            } while (true);
        }


        public static void Run2()
        {
            string userInput;
            double distance;
            string[] distanceAndUnits;
            do
            {
                Console.Write("Enter a distance and its unit (km or mi) spaced with a space to be converted or press 'q' to quit : ");
                userInput = Console.ReadLine();
                if (userInput.Equals("q"))
                {
                    Console.WriteLine("Bye bye");
                    Environment.Exit(0);
                }
                else
                {
                    distanceAndUnits = userInput.Split(' ');
                    if (CheckIsNumber(distanceAndUnits[0], out distance))
                    {
                        if (distance > 0.01d && distance < 1000000d)
                        {
                            if (CheckIfMiles(distanceAndUnits))
                            {
                                Console.WriteLine($"{distance} miles are equal to {ConvertMilesToKilometers(distance)} kilometers");
                            }
                            else
                            {
                                Console.WriteLine($"{distance} kilometers are equal to {ConvertKilometersToMiles(distance)} miles");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Input\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input\n");
                    }
                }
            } while (true);
        }
    }
    

}
