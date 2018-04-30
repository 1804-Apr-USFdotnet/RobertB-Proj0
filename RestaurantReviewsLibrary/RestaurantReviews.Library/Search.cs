using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    class Search
    {
        public static void Lookup(List<Restaurant> restaurants, string sub)
        {
            foreach (var one in restaurants)
            {
                if (one.Name.Contains(sub))
                    Console.WriteLine(one.ID + " " + one.Name);
            }
        }
    }
}
