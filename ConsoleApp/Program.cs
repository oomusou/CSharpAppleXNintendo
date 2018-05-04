using System;
using ClassLibrary;
using ClassLibrary.Combo;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCartService = new ShoppingCartService();
            shoppingCartService.AddCart(new AppleXNintendo());

            var result = shoppingCartService.CalculatePrice();
            Console.WriteLine("{0}", result);
        }
    }
}