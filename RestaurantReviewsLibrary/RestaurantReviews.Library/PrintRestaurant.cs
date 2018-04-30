using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    class PrintRestaurant
    {
        public static void PrintRestaurantByName(List<Restaurant> rest, string text)
        {
            text = text.ToLower();
            foreach (var list in rest)
                if ((list.Name.ToLower()) == text)
                    Console.WriteLine(list.Name.ToString());
        }
        public static void PrintRestaurantById(List<Restaurant> rest, int id)
        {
            foreach (var list in rest)
                if (list.ID == id)
                    Console.WriteLine(list.Name.ToString());
        }
        public static void PrintReviews(List<Restaurant> rest, string text)
        {
            text = text.ToLower();
            foreach (var list in rest)
                if ((list.Name.ToLower()) == text)
                    foreach (var review in list.reviews)
                        Console.WriteLine(review.ToString());
        }
        public static void PrintReviewsById(List<Restaurant> rest, int id)
        {
            foreach (var list in rest)
                if (list.ID == id)
                    foreach (var review in list.reviews)
                        Console.WriteLine(review.ToString());
        }
    }
}
