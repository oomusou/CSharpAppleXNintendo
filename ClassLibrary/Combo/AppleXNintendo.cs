using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Combo
{
    public class AppleXNintendo : ComboBase
    {
        private int _minus = 1000;

        public AppleXNintendo()
        {
            Products = new List<IPrice>
            {
                new Apple(),
                new Nintendo()
            };
        }

        public override double GetPrice()
        {
            return base.GetPrice() - _minus;
        }
    }
}