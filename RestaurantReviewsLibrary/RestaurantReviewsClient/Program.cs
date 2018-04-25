using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            bool execute = true;
            while (execute)
            {
                Console.WriteLine("Press the number corresponding to the option you want:");
                Console.WriteLine("1. Display the top 3 restaurants by average rating.");
                Console.WriteLine("2. Display all restaurants.");
                Console.WriteLine("3. Display details of a restaurant.");
                Console.WriteLine("4. Display all the reviews of a restaurant");
                Console.WriteLine("5. Search for a restaurant.");
                Console.WriteLine("6. Quit Application");
                x = Convert.ToInt32(Console.ReadLine());
                while (x>6 || x<1)
                {
                    Console.WriteLine("That is an invalid input. Please try again: ");
                    x = Convert.ToInt32(Console.ReadKey());
                }
                switch(x)
                {/*
                    case 1 :
                        {
                            ;
                        }
                    case 2
                        {
                            ;
                        }
                    case 3
                        {
                            ;
                        }
                    case 4
                        {
                            ;
                        }
                    case 5
                        {
                            ;
                        }*/
                    case 6 :
                        {
                            execute=false;
                            break;
                        }
                }
            }            
        }
    }
}
