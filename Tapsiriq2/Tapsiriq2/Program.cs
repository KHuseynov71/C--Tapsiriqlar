using System;

namespace Tapsiriq2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,0};
            int count = 0, sum = 0;
            for (int i = 1; i < nums.Length; i += 2)
            {

                sum += nums[i];
            }   count++;
            sum = sum /count;
            Console.WriteLine(sum);
        }
        }
    }

