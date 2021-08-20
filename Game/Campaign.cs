using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Campaign
    {
        private int _discountPercentage;
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountPercentage
        {
            get
            {
                return _discountPercentage;
            }
            set
            {
                if ((value >= 0) && (value <= 100))
                {
                    _discountPercentage = value;
                }
                else
                {
                    _discountPercentage = 0;
                }
            }
        }
    }
}
