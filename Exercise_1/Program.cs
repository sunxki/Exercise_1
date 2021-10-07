using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class 1 
            Class1 test = new Class1();
            int[] randomNumbers = { 10, 2, 3, 15, 5, 52, 8, 101};
            string[] champs = { "Fizz", "Vayne", "Ashe" };
            // StringComparison()
            Console.WriteLine(test.StringComparison("Hoi", "Hoi"));
            //VerifyBiggestNumber()
            test.VerifyBiggestNumber(randomNumbers);
            //SortList()
            test.SortList(champs);
            //CountStringLength()
            Console.WriteLine(test.CountStringLength("David"));
            Console.WriteLine("----");
            //Class 2 
            Class2 test2 = new Class2();
            test2.PrintFirstFiveValues(randomNumbers);
            test2.PrintSmallestNumber(randomNumbers);
            test2.PrintDictionary();
            
            


            Console.ReadLine();
        }
    }
}
