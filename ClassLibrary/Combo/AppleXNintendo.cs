using System.Collections.Generic;
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
            return GetSumOfPrice(sum => sum - _minus);
        }
    }
}