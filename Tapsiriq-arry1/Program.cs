using System;

namespace Tapsiriq_arry1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 7, 3, -5, 1, 9 };
            int num = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > nums[i])

                    num = nums[i];


            }
            Console.WriteLine(num) ;
        }
    }
}
