using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Interfaces;
using ClassLibrary.Nintendo;

namespace ClassLibrary.Combo
{
    public class Nintendo : IPrice
    {
        private double _discount = 0.9;
        private readonly List<IPrice> _products;

        public Nintendo()
        {
            _products = new List<IPrice>
            {
                new Switch(),
                new Zelda()
            };
        }
        
        public double GetPrice()
        {
            return _discount * _products.Sum(product => product.GetPrice());
        }
    }
}