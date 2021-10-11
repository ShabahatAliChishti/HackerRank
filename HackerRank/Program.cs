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
            //find the sum of its elements
            //give an array  ar=[1,2,3]=1+2+3=6,so return 6


            int[] ar = new int[] { 1, 2, 3 };
            //first method by forloop
           Console.WriteLine(dummyclass.simpleArraySum(ar));
            //second method by linq
            Console.WriteLine(ar.Sum());



        }
        public  static class dummyclass

        {
          public  static int simpleArraySum(int[] ar)
            {
                int sum = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    sum += ar[i];
                }
                return sum;

            }
        }
    }
}
