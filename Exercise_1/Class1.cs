using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Class1
    {
        public string StringComparison(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return a;

            }
            return b;   

        }

        public void VerifyBiggestNumber(int[] matrix)
        {
            Console.WriteLine(matrix.Max());
        }

        public void SortList(string[] matrix)
        {
            Console.WriteLine("--ASC--");
            matrix = matrix.OrderBy(d => d).ToArray();
            Array.ForEach(matrix, x => Console.WriteLine(x));
            Console.WriteLine("--DESC--");
            matrix = matrix.OrderByDescending(d => d).ToArray();
            Array.ForEach(matrix, x => Console.WriteLine(x));

        }

        public int CountStringLength(string word)
        {
            return word.Length;
        }


    }
}
