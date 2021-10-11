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
            string str = "interview";

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach(var character in str)
            {
                if (character !=' ')

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
            foreach(var character in charCount)
            {
                Console.WriteLine("{0}-{1}", character.Key, character.Value);
            }

        }
    }
}
