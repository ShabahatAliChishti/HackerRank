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
            //number find krna hai list me exist krta hai tou YES return krna hai wrna No
            var testCases = new List<Tuple<List<int>, int>>();
            var numbers = new List<int> { 1, 5, 8, 4, 9, 11, 4 };
            testCases.Add(new Tuple<List<int>, int>(numbers, 5));
            testCases.Add(new Tuple<List<int>, int>(numbers, 2));
            testCases.Add(new Tuple<List<int>, int>(numbers, 4));

            foreach (var testCase in testCases)
            {
                Console.WriteLine(findNumber(testCase.Item1,testCase.Item2));
            }


        }
      static string findNumber(List<int> arr,int k)
        {
            return arr.Any(element => element == k) ? "YES" : "NO";
        }

    }
}
