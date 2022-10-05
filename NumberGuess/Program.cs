using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guess");

            Random rnd = new Random();
            int number = rnd.Next(1, 11);
            
            /*
            Console.WriteLine("number = {0}", number);
            */

            /*
            for (int i = 1; i <= 10; i++)
            {
                int counter = 0;
                for (int j = 1; j < 1000; j++)
                {
                    number = rnd.Next(1, 10);
                    if (number == i) counter++;
                }
                Console.WriteLine("Frequency of (0) is (1) out of 1000", i, counter);
            }
            */

            Console.WriteLine("Guess the number from 1 to 10: ");

            int guess;
            bool valid;

            /*
            valid = Int32.TryParse(Console.ReadLine(), out guess);
            if (valid) if (guess == number)
                {
                    Console.WriteLine("You win");
                    return;
                };
            Console.WriteLine("You loose");
            */

            while (true)
            {
                valid = Int32.TryParse(Console.ReadLine(), out guess);
                if (valid) if (guess == number)
                    {
                        Console.WriteLine("You win"); return;
                    }
                if (!valid)
                {
                    Console.WriteLine("Invalid input, try again");
                    continue;
                }
                if (guess < number)
                    Console.WriteLine("Too low, please try again");
                else
                    Console.WriteLine("Too high, please try again");
            }
        }
    }
}
