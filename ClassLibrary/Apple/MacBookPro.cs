using ClassLibrary.Interfaces;

namespace ClassLibrary.Apple
{
    public class MacBookPro : IPrice
    {
        private double _price = 60000.0;

        public double GetPrice()
        {
            return _price;
        }
    }
}