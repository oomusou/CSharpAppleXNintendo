using ClassLibrary.Interfaces;

namespace ClassLibrary.Nintendo
{
    public class Switch : IPrice
    {
        private double Price = 10000.0;

        public double GetPrice()
        {
            return Price;
        }
    }
}