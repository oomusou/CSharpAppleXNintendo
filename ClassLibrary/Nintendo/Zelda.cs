using ClassLibrary.Interfaces;

namespace ClassLibrary.Nintendo
{
    public class Zelda : IPrice
    {
        private double _price = 2000.0;

        public double GetPrice()
        {
            return _price;
        }
    }
}