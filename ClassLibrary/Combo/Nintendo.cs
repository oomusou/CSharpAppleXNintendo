using System.Collections.Generic;
using ClassLibrary.Interfaces;
using ClassLibrary.Single.Nintendo;

namespace ClassLibrary.Combo
{
    public class Nintendo : ComboBase
    {
        private double _discount = 0.9;

        public Nintendo()
        {
            Products = new List<IPrice>
            {
                new Switch(),
                new Zelda()
            };
        }
        
        public override double GetPrice()
        {
            return GetSumOfPrice(sum => _discount * sum);
        }
    }
}