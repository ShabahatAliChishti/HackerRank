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

            //print count of duplicate characters from string
            string str = "interview";
            //to store our character and occurence of that
            //i is char and 2 in int in interview string
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!charCount.ContainsKey(character))
                    {
                        charCount.Add(character, 1);
                    }
                    else
                    {
                        charCount[character]++;
                    }
                }
            }
            foreach (var character in charCount)
            {
               if(character.Value>1)
                {
                    Console.WriteLine("{0}-{1}", character.Key, character.Value);
                }

            }
            Console.ReadLine();
        }


    }
}
