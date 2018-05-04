using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Combo
{
    public abstract class ComboBase : IPrice
    {
        protected List<IPrice> Products;
        
        protected double GetSumOfPrice(Func<double, double> action)
        {
            return action(Products.Sum(product => product.GetPrice()));
        }

        public abstract double GetPrice();
    }
}