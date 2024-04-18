using System;

namespace OopPrinciples.Delivery
{
    /// <summary>
    /// Доставка в пункт выдачи
    /// </summary>
    class PickPointDelivery : Delivery
    {
        /// <inheritdoc cref="Price" />
        private readonly decimal _price;

        /// <inheritdoc />
        public override decimal Price => _price;
        
        /// <summary>
        /// Время доставки
        /// </summary>
        private readonly TimeSpan _timeFrom = TimeSpan.FromHours(9);

        /// <summary>
        /// Время доставки
        /// </summary>
        private readonly TimeSpan _timeTo = TimeSpan.FromHours(20);

        private PickPointDelivery()
        { }

        /// <inheritdoc />
        public PickPointDelivery(string address) : base(address)
        { }

        /// <inheritdoc />
        public override void DisplayDeliveryInformation()
        {
            Console.WriteLine("Тип доставки: доставка в пункт выдачи.");
            Console.WriteLine("Адрес пункта выдачи: {0}.", Address);
            Console.WriteLine("Дата доставки: {0}.", DeliveryDate);
            Console.WriteLine("Время работы пункта выдачи: {0}-{1}.", _timeFrom.ToString(@"hh\:mm"), _timeTo.ToString(@"hh\:mm"));            
            Console.WriteLine("Стоимость доставки: {0}.", Price);
        }
    }
}
