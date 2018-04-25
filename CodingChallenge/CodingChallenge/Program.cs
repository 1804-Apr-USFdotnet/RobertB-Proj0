using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            CCLib check = new CCLib();
            Console.WriteLine("Please enter a phrase: ");
            test = Console.ReadLine();
            if (check.Check(test))
                Console.WriteLine(test + " is a palindrome.");
            else
                Console.WriteLine(test + " is not a palindrome.");
            Console.ReadKey();
        }
    }
}
