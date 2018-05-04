using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Apple;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Combo
{
    public class Apple : IPrice
    {
        private double _discount = 0.9;
        private readonly List<IPrice> _products;

        public Apple()
        {
            _products = new List<IPrice>
            {
                new MacBookPro(),
                new PadAir(),
                new AppleWatch()
            };
        }
        
        public double GetPrice()
        {
            return _discount * _products.Sum(product => product.GetPrice());
        }
    }
}