using ClassLibrary.Interfaces;

namespace ClassLibrary.Apple
{
    public class PadAir : IPrice
    {
        private double _price = 10000.0;

        public double GetPrice()
        {
            return _price;
        }
    }
}