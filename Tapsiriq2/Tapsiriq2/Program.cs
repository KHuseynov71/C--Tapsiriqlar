using System;

namespace Tapsiriq2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "February";
            if (month == "January" || month == "March" || month == "May" || month == "July" || month == "August" || month == "October" || month == "December")
            {
                Console.WriteLine("31");
            }
            if (month == "April" || month == "June" || month == "September" || month == "November")
            {
                Console.WriteLine("30");
            }
            if (month == "February")
            {
                Console.WriteLine("28 or 29");
            }

        }
    }
}
