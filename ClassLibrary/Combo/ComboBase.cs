using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Combo
{
    public abstract class ComboBase : IPrice
    {
        protected List<IPrice> Products;
        
        public virtual double GetPrice()
        {
            return Products.Sum(product => product.GetPrice());
        }
    }
}