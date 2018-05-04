using ClassLibrary.Interfaces;

namespace ClassLibrary.Single
{
    public abstract class SingleBase : IPrice
    {
        protected double Price;

        public double GetPrice()
        {
            return Price;
        }
    }
}