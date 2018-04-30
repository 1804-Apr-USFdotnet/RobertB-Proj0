using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    public class MethodCalls
    {
        public static List<Restaurant> rest = new List<Restaurant>();
        public static List<Reviews> rev = new List<Reviews>();
        public static void Topthree()
        {
            if(rest == null)
            {
                //Serializer.SetList();
            }
            Sort.TopThree(rest);
        }
        public static void chooseSort(int x)
        {
            if (rest == null)
            {
                //Serializer.SetList();
            }
            if (x == 1)
                Sort.AlphabeticalSort(rest);
            if (x == 2)
                Sort.AlphabeticalReverseSort(rest);
            if (x == 3)
                Sort.StringSizeSort(rest);
        }
        public static void returnRestByName(string name)
        {
            if (rest == null)
            {
                //Serializer.SetList();
            }
            PrintRestaurant.PrintRestaurantByName(rest, name);
        }
        public static void returnRestById(int id)
        {
            if (rest == null)
            {
                //Serializer.SetList();
            }
            PrintRestaurant.PrintRestaurantById(rest, id);
        }
        public static void getReviewsByName(string name)
        {
            if (rest == null)
            {
                Serializer.SetList();
            }
            PrintRestaurant.PrintReviews(rest, name);
        }
        public static void getReviewsById(int id)
        {
            if (rest == null)
            {
                //Serializer.SetList();
            }
            PrintRestaurant.PrintReviewsById(rest, id);
        }
        public static void searchRestName(string sub)
        {
            if (rest == null)
            {
                //Serializer.SetList();
            }
            Search.Lookup(rest, sub);
        }
    }
}
