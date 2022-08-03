using System;

namespace Tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int min = 7;
                int max = 77;
                int i = 0;
                while (min <= max)
                {
                    if (min % 7 == 0)
                    {
                        i++;
                    }
                    min++;
                }
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
