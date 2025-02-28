using System;
using System.Collections;
using System.Runtime.Serialization;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {

             Random rnd = new Random();
            int numberToGuess = rnd.Next(31);

            bool correct = true;

            int nbrsp = 0;

            while (correct)
            {
                Console.WriteLine("Insert number: ");

                string x = Console.ReadLine();

                int response = int.Parse(x);


                if (response == numberToGuess)
                    correct = false;

                nbrsp += 1;

                if (response>30)

                    Console.WriteLine("Numbers must be between 0 and 30. Try again.");

                else if (response<0)

                    Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                

                else if (response > numberToGuess)

                    Console.WriteLine($"The hidden number is lower than {x}. Try again.");

                else if (response < numberToGuess)

                    Console.WriteLine($"The hidden number is higher than {x}. Try again.");

                else if (response == numberToGuess)

                    Console.WriteLine($"You found the hidden number {numberToGuess} after {nbrsp} tries");
            }


        }
    }
}
