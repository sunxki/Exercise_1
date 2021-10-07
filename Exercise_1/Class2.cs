using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Class2
    {
        public void PrintFirstFiveValues(int[] numbers)
        {
            Console.WriteLine("First 5 values\n");
            for (int i = 0; i <=4; i++)
            {
            
                Console.WriteLine(numbers[i] ); 
            }
        }

        public void PrintSmallestNumber(int[] numbers)
        {
            int lower = numbers[0];
            for (int i = 0; i<=numbers.Length-1;i++)
            {
                if (lower > numbers[i])
                {
                    lower = numbers[i];
                }
            }
            Console.WriteLine("The lowest number is " + lower);
        }

        public void PrintDictionary()
        {
            Console.WriteLine("Dictionary");
            Dictionary<string, int> champs = new Dictionary<string, int>();
            champs.Add("Vayne", 42);
            champs.Add("Fizz", 38);
            champs.Add("Kaisa", 12);
            champs.Add("Ashe", 12);
            Console.WriteLine(champs["Vayne"]);
        }

    }
}
