using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Written by Quinn Luck as a test of his knowledge of C#
/// Apr. 2017
/// </summary>
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); 
            list = findMultiples(1000);

            int sum = 0;
            sum = sumList(list);

            for(int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }
            Console.WriteLine(sum);
        }

        /// <summary>
        /// findMultiples finds all multiples of 3 and 5 from 1 to a limit
        /// </summary>
        /// <param name="limit"> An integer limit </param>
        /// <returns> an integer List of all numbers with a multiple of 3 or 5 </returns>
        public static List<int> findMultiples(int limit)
        {
            List<int> multiples = new List<int>();
            for(int i = 0; i < limit; i++)
            {
                int a = i % 3;
                int b = i % 5;
                if(a == 0)
                {
                    multiples.Add(i);
                }
                else if(b == 0)
                {
                    multiples.Add(i);
                }
            }
            return multiples;
        }

        /// <summary>
        /// Sums all integers in a given list
        /// </summary>
        /// <param name="list"> List of numbers to sum </param>
        /// <returns> an integer sum </returns>
        public static int sumList(List<int> list)
        {
            return list.Sum();
        }
    }
}
