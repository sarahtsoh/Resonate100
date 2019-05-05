using System;
using System.Collections.Generic;
using System.Linq;

namespace ResonateL100
{
    class Program
    {
        static void Main(string[] args)
        {
            //L100 Question 1
            var list = new List<int>();

            list.Add(12);
            list.Add(11);
            list.Add(12);
            list.Add(21);
            list.Add(41);
            list.Add(43);
            list.Add(21);

            var output = GetDistinct(list);

            foreach (var i in output)
            {
                Console.WriteLine(i);
            }

            //L100 Question 2
            string s1 = "ABCDEFGAB";

            string s2 = "BBCDEFGAA";
            var result =  IsPermutation(s1, s2);
            Console.WriteLine(result.ToString());

        }


        public static List<int> GetDistinct(List<int> input)
        {
            return input.Distinct().ToList();
           
        }

        public static bool IsPermutation(string s1, string s2)
        {
            bool result = false;
            if (s1.Count() != s2.Count())
                return result;

            var List1 = s1.ToCharArray().Distinct();
            
            foreach (var cha in List1)
            {
                var s1Count = s1.Where(c => c == cha).Count();

                var s2Count = s2.Where(c => c == cha).Count();

                if (s1Count != s2Count)
                    return result;
            }

            result = true;

            return result;
        }


    }
}
