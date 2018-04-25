using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Library
{
    public class Restaurant
    {
        public string Name { get; set; }
        public double AvgRating { get; set; }
        public string[] Address { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string ID { get; set; }
    }

    public class RestaurantList : Restaurant
    {
        List<Restaurant> rest = new List<Restaurant>();
    }
}
