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
            //complete the function solvemefirst to compute the sum of two integeres.
            //sample input a=2 and b=3
            //sample output 5
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(solvemeFirst(val1, val2));

        }
        static int solvemeFirst(int a,int b)
        {
            return a + b;
        }
       
    }
}
