using System;

namespace lesson22
{
    class Program
    {

        static void Main(string[] args)
        {
            //Создвли обьектт класса рандом
            Random rnd = new Random();
            ConsoleKeyInfo attempt;
            int max = 0;
            int min = 0;
            int gameCount = 0;
            int tries = 0;
            do
            {
                gameCount++;
                int currenttries = 0;
                int RandomNumber = rnd.Next(1, 11);
                while (true)


                {
                    tries++;
                    currenttries++;
                    int result = 0;
                    Console.WriteLine("Enter desired number in [1;100]");
                    while (!int.TryParse(Console.ReadLine(), out result)
                        || (result > 100 || result < 1))
                        Console.WriteLine("ERROR. enter correct number in [1;100]");
                    if (result > RandomNumber)
                        Console.WriteLine("Desired number is smaller");
                    else if (result < RandomNumber)
                        Console.WriteLine("Desired number is bigger");
                    else

                    {
                        Console.WriteLine("You have won!");
                        break;
                    }

                }
                tries += currenttries;
                max = max < currenttries ? currenttries : max;
                // if (max < currenttries) max = currentries
                if (min > currenttries) min = currenttries;

                Console.WriteLine("Do you want to play a game one more time? Enter Y/N");
                attempt = Console.ReadKey();
                Console.WriteLine();
            } while (attempt.Key == ConsoleKey.Y);
            Console.WriteLine($"Max = {max}.\nMin = {min}.\nAvg = {Convert.ToDouble (tries)/gameCount}.");
        }
    }
}




