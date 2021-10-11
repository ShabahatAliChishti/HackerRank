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
            //Calculate and print the sum of the elements in an array.keeping in mind that some of those integeres may a quite large.
            //input format :the first line of the input consists of an integer n.
            //the next line contains n space-spearated integers contained in the array
            //output:print the sum of the elements in the array
            //Sample input:
            //5 
            //10000001 10000002 1000000003 1000000004 100000005

            //output:500000015
            long []ar;
            ar = new long[] { 1000000001, 1000000002, 1000000003 };

            Console.WriteLine(averyBigSum(ar));


        }
        static long  averyBigSum(long[] ar)
        {
            long sum = 0;
          for(int i=0;i<ar.Length;i++)
            {
                sum += ar[i];
            }
            return sum;
        }
       
    }
}
