using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Combo
{
    public class AppleXNintendo : IPrice
    {
        private int _minus = 1000;
        private readonly List<IPrice> _products;

        public AppleXNintendo()
        {
            _products = new List<IPrice>
            {
                new Apple(),
                new Nintendo()
            };
        }

        public double GetPrice()
        {
            return _products.Sum(product => product.GetPrice()) - _minus;
        }
    }
}