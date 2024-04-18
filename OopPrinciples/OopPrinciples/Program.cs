using OopPrinciples.Delivery;
using OopPrinciples.Order;
using OopPrinciples.Persons;
using OopPrinciples.Products;
using OopPrinciples.ShoppingCarts;
using System;

namespace OopPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new[]
            {
                new Product ("Phone", 100),
                new Product ("Book", 10)
            };

            var shoppingCart = new ShoppingCart();

            var customer = new Customer("Иван", "Иванов", "+7 (999) 999-99-99", shoppingCart);

            customer.AddProductToCart(products);

            var address = "test address";

            var courier = new Courier("Петр", "Петров", "+7 (800) 555-35-35", "A111AA797");
            
            var delivery = new HomeDelivery(address, courier);

            var order = new Order<HomeDelivery>(customer, delivery);

            order.DisplayOrderInformation();

            Console.WriteLine();

            order.DisplayDeliveryInformation();

            Console.ReadKey();
        }
    }
}
