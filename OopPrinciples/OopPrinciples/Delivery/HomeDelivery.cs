using OopPrinciples.Persons;
using System;

namespace OopPrinciples.Delivery
{
    /// <summary>
    /// Доаставка на дом
    /// </summary>
    internal class HomeDelivery : Delivery
    {
        /// <inheritdoc cref="Price" />
        private readonly decimal _price;

        /// <inheritdoc />
        public override decimal Price => _price;

        /// <summary>
        /// Курьер
        /// </summary>
        private readonly Courier _courier;

        /// <summary>
        /// Время доставки
        /// </summary>
        private readonly TimeSpan _timeFrom = TimeSpan.FromHours(10);

        /// <summary>
        /// Время доставки
        /// </summary>
        private readonly TimeSpan _timeTo = TimeSpan.FromHours(22);

        private HomeDelivery()
        { }

        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="address"><inheritdoc cref="Delivery(string)" path="/param[@name='address']"/></param>
        /// <param name="courier"><inheritdoc cref="_courier" path="/summary"/></param>
        public HomeDelivery(string address, Courier courier) : base(address)
        {
            var rnd = new Random();
            _price = rnd.Next(100, 200);

            _courier = courier;
        }

        /// <inheritdoc />
        public override void DisplayDeliveryInformation()
        {
            Console.WriteLine("Тип доставки: доставка курьером на дом.");
            Console.WriteLine("Адрес доставки: {0}.", Address);
            Console.WriteLine("Дата доставки: {0}.", DeliveryDate);
            Console.WriteLine("Время доставки: {0}-{1}.", _timeFrom.ToString(@"hh\:mm"), _timeTo.ToString(@"hh\:mm"));
            Console.WriteLine("Курьер: {0} {1}.", _courier.Name, _courier.LastName);
            Console.WriteLine("Номер курьера: {0}.", _courier.PhoneNumber);
            Console.WriteLine("Номер автомобиля курьера: {0}.", _courier.CarNumber);
            Console.WriteLine("Стоимость доставки: {0}.", Price);
        }
    }
}
