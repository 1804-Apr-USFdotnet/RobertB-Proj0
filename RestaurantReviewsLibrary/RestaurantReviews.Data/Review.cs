//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantReviews.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int RestaurantId { get; set; }
        public string Reviewer { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
        public virtual Restaurant Restaurant1 { get; set; }
    }
}
