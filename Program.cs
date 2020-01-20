using System;

namespace QuadaxConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            String answer;
            int guesses = 0;
            int maxGuesses = 10;
            answer = rand.Next(1, 7).ToString() + rand.Next(1, 7).ToString() + rand.Next(1, 7).ToString() + rand.Next(1, 7).ToString();
            while (guesses < maxGuesses)
            {
                Console.WriteLine("Type your guess:");
                String guess = Console.ReadLine();

                for (int x = 0; x < 4; x++)
                {
                    if (guess.Substring(x, 1).Equals(answer.Substring(x, 1)))
                    {
                        Console.WriteLine("+");
                    }
                     else if (answer.Contains(guess.Substring(x, 1)))
                    {
                        Console.WriteLine("-");
                    }
                }
                guesses++;
            }

            if(guesses == 10)
            {
                Console.WriteLine("You have used all your tries, thank you for playing!");
            }
            
            Console.Write("Press any key to close the console !");
            Console.ReadKey();
        }

    }
}
