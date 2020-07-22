using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Entity
{
    public class Sliders
    {
        public int Id { get; set; }
        public List<Slider> Slider { get; set; }
        public List<discount_of_the_day> discount_Of_The_Days { get; set; }
        public List<Fixed_photo> fixed_Photos { get; set; }
        public List<last_15_sold>  last_15_Solds { get; set; }
        public List<Offers>  Offers { get; set; }
        public List<Today_is_offer>  GetToday_Is_Offers { get; set; }

    }
}
