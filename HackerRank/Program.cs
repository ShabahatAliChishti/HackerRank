using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Minmax sum problem
            //getting array of integers that are between 1 and  10 to the 9th and our job is to figure the minimum value that we can make with four elements and the 
            //maximum sum  that we can make with any four elements each element only used once so one thing i failed to mention was that our array is guaranteed to only have five elements in it and the end we'll be outputing to the console the minimm value and the maximum value

            //    to achieveing this
            //    steps:
            //    1)Sort the array from least to greatest q ke pehli 4 value smallest hongi tou unka sum jo hoga woh  smallest possible sum hoga or phr last 4 values degi greatest  possible sum
            //        so in order to sort this we use array sort library
            //}

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),
                arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
        static void miniMaxSum(int[]arr)
        {
            //sort array
            Array.Sort(arr);
            long min = arr.Take(4).Sum(item => (long)item);
            long max = arr.Skip(1).Sum(item => (long)item);
            Console.WriteLine($"{max} {min} ");
        }

    }
}
