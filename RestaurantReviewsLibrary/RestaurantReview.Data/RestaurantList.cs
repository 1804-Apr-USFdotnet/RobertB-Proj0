using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Data
{
    public partial class RestaurantList : Component
    {
        public RestaurantList()
        {
            InitializeComponent();
        }

        public RestaurantList(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
