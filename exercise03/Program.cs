using System;

namespace exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Pls enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("{0} = {1}", number, factorial);
        }
    }
}
