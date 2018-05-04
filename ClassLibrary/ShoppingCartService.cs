using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{
    public class ShoppingCartService
    {
        private readonly List<IPrice> _carts = new List<IPrice>(); 

        public void AddCart(IPrice product)
        {
            _carts.Add(product);
        }

        public double CalculatePrice()
        {
            return _carts.Sum(product => product.GetPrice());
        }
    }
}