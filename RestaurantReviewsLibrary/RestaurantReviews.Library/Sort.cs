using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    class Sort
    {
        public static void AlphabeticalSort(List<Restaurant> rest)
        {
            rest.OrderBy(x => x.Name);
            foreach (var list in rest)
                Console.WriteLine(list.Name);
        }
        public static void AlphabeticalReverseSort(List<Restaurant> rest)
        {
            rest.OrderBy(x => x.Name);
            rest.Reverse();
            foreach (var list in rest)
                Console.WriteLine(list.Name);
        }
        public static void StringSizeSort(List<Restaurant> rest)
        {
            var length = from element in rest
                         orderby element.Name.Length
                         select element;
            foreach (var list in length)
                Console.WriteLine(list.Name);
        }
        public static void TopThree(List<Restaurant> rest)
        {
            rest.OrderBy(x => x.AvgRating);
            rest.Reverse();
            for (int i = 0; i < 3; i++)
                Console.WriteLine(rest.ElementAt(i).Name);
        }
    }
}
