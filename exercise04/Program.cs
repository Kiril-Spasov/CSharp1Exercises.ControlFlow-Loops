using System;

namespace exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random().Next(1, 10);
            Console.WriteLine("Secret is: " + random);

            for (var i = 1; i <= 4; i++)
            {
                Console.WriteLine("Guess the number");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == random)
                {
                    Console.WriteLine("You won");
                    return;
                }

            }
            Console.WriteLine("You lost");
        }
    }
}
