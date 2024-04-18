using System;

namespace OopPrinciples.Delivery
{
    /// <summary>
    /// Доставка в отделение магазина
    /// </summary>
    internal class ShopDelivery : Delivery
    {
        /// <inheritdoc cref="Price" />
        private readonly decimal _price = 0;

        /// <inheritdoc />
        public override decimal Price => _price;

        private ShopDelivery()
        { }

        /// <inheritdoc />
        public ShopDelivery(string address) : base(address)
        { }

        /// <inheritdoc />
        public override void DisplayDeliveryInformation()
        {
            Console.WriteLine("Тип доставки: доставка выполняется в отделение магазина своими средствами.");
            Console.WriteLine("Адрес доставки: {0}.", Address);
            Console.WriteLine("Дата доставки: {0}.", DeliveryDate);
            Console.WriteLine("Стоимость доставки: {0}.", Price);
        }
    }
}
