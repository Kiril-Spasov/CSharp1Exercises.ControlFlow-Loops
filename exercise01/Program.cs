using System;

namespace exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }
    }
}
