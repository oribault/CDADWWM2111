using System;
using System.Text;

namespace Exercice_1._1._3
{
    class Program
    {
        private static object _sentence;

        static void Main(string[] args)
        {
            String userInputNumbers;
            int howManyNumbers;
            int sumNumbers;
            int countNumbers;
            int tabNumbers;
            int average;

            Console.WriteLine("Enter numbers spaced width");
            userInputNumbers = Console.ReadLine();

            private int[] split(string string_sentence, char _charWWichSplit)
            {
                int howManyInt;
                int numbersCounter;
                int[] arrayInt;
                StringBuilder numberInString;

                howManyInt = 0;
                for(int charCounter =0; charCounter <= string_sentence.Length - 1; charCounter++)
                {
                    if (string_sentence[charCounter].Equals(_charWWichSplit))
                    {
                        howManyInt = howManyInt + 1;
                    }
                }

                numbersCounter = 0;
                numberInString = new StringBuilder();
                arrayInt = new int[howManyInt];
                for(int charCounter = 0; charCounter < _sentence.Length; charCounter ++)

            }
        }
    }
}
