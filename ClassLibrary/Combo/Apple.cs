using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Interfaces;
using ClassLibrary.Single.Apple;

namespace ClassLibrary.Combo
{
    public class Apple : ComboBase
    {
        private double _discount = 0.9;

        public Apple()
        {
            Products = new List<IPrice>
            {
                new MacBookPro(),
                new PadAir(),
                new AppleWatch()
            };
        }
        
        public override double GetPrice()
        {
            return _discount * base.GetPrice();
        }
    }
}