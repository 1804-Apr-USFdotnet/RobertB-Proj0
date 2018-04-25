using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary
{
    class Reviews
    { 
        public string Reviewer { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }

        public override string ToString()
        {
            return $"Rating: {Rating}\n {Reviewer}: {Rating}";          
        }
    }

    class ReviewsList : Reviews
    {
        List<Reviews> reviewList = new List<Reviews>();
    }
}
