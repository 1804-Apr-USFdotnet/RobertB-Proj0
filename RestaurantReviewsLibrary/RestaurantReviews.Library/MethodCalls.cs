using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Data;

namespace RestaurantReviews.Library
{
    public class MethodCalls
    {
        public static List<Restaurant> rest = new List<Restaurant>();
        public static List<Restaurant> newList = new List<Restaurant>();
        public static Restaurant pop = new Restaurant();
        public static List<Reviews> rev = new List<Reviews>();
        public static Reviews singleRev = new Reviews();

        public static void SetLibRest()
        {
            rest = GetLibRestaurants();
        }

        public static Reviews ImportReview(RestaurantReviews.Data.Review dlRev)//DataToLibrary
        {
            int revId = dlRev.RestaurantId;
            var libRev = new Reviews()
            {
                RestaurantId = dlRev.RestaurantId,
                Reviewer = dlRev.Reviewer,
                Comment = dlRev.Comment,
                Rating = dlRev.Rating
            };
            return libRev;
        }


        public static Review GetReviewById(int id)
        {
            Review miniRev;
            var dbRev = new RestaurantDBEntities();
            miniRev = dbRev.Reviews.Find(id);
            return miniRev;
        }
        public static IEnumerable<RestaurantReviews.Data.Review> GetReviewsByID(int restId)
        {
            IEnumerable<RestaurantReviews.Data.Review> reviewList;
            var dbRevs = new RestaurantDBEntities();
            reviewList = dbRevs.Reviews.Where(x => x.RestaurantId == restId).ToList();
            return reviewList;
        }
        public static List<Reviews> GetRevListById(int restId)
        {
            return GetReviewsByID(restId).Select(x => ImportReview(x)).ToList();
        }
        public static Restaurant SetRest(RestaurantReviews.Data.Restaurant dlRest)
        {
            int restId = dlRest.ID;
            List<Reviews> revList = GetRevListById(restId);
            var restModel = new Restaurant()
            {
                ID = dlRest.ID,
                Name = dlRest.Name,
                Address = dlRest.Address,
                Street = dlRest.Street,
                City = dlRest.City,
                State = dlRest.State,
                PhoneNumber = dlRest.PhoneNumber,
                Zip = (int)dlRest.Zip,
                reviews = revList
            };
            restModel.AvgRating = restModel.CalcAvgRating();
            return restModel;
        }
        public static IEnumerable<RestaurantReviews.Data.Restaurant> GetRestaurants()
        {
            IEnumerable<RestaurantReviews.Data.Restaurant> dlRest;
            var dbList = new RestaurantDBEntities();
            dlRest = dbList.Restaurants.ToList();
            return dlRest;
        }
        public static List<Restaurant> GetLibRestaurants()
        {
            return GetRestaurants().Select(x => SetRest(x)).ToList();
        }

        public static void Topthree()
        {
            /*if(rest == null)
            {
               //Serializer.SetList();
            }*/
            newList = Sort.AvgRatingSort(rest);
            for (int i = 0; i < 3; i++)
                Console.WriteLine(newList.ElementAt(i).Name + " Rating: " + newList.ElementAt(i).AvgRating);
        }
        public static void chooseSort(int x)
        {
            /*if (rest == null)
            {
                //Serializer.SetList();
            }*/
            if (x == 1)
                newList = Sort.AlphabeticalSort(rest);
            if (x == 2)
                newList = Sort.AlphabeticalReverseSort(rest);
            if (x == 3)
                newList = Sort.StringSizeSort(rest);
            if (x == 4)
                newList = Sort.AvgRatingSort(rest);
            foreach (var i in newList)
                Console.WriteLine(i.Name);
        }
        public static void returnRestByName(string name)
        {
            /*if (rest == null)
            {
                //Serializer.SetList();
            }*/
            newList = PrintRestaurant.PrintRestaurantByName(rest, name);
            foreach (var restList in newList)
                Console.WriteLine(restList.ToString());
        }
        public static void returnRestById(int id)
        {
            /*if (rest == null)
            {
                //Serializer.SetList();
            }*/
            newList = PrintRestaurant.PrintRestaurantById(rest, id);
            foreach (var restList in newList)
                Console.WriteLine(restList.ToString());
        }
        public static void getReviewsByName(string name)
        {
            /*if (rest == null)
            {
                //Serializer.SetList();
            }*/
            newList = PrintRestaurant.PrintReviews(rest, name);
            foreach (var member in newList)
                Console.WriteLine(member.reviews.ToString());
        }
        public static void MCReviewsById(int id)
        {
            /*if (rest == null)
            {
                //Serializer.SetList();
            }*/
            newList = PrintRestaurant.PrintReviewsById(rest, id);
            foreach (var member in newList)
                Console.WriteLine(member.reviews.ToString());
        }
        public static void searchRestName(string sub)
        {
            /*if (rest == null)
            {
               //Serializer.SetList();
            }*/
            newList = Search.Lookup(rest, sub);
            foreach (var name in newList)
                Console.WriteLine(name.Name);
        }
    }
}
