using System;

namespace OopPrinciples.Delivery
{
    /// <summary>
    /// Абстрактный класс доставки
    /// </summary>
    internal abstract class Delivery
    {
        /// <summary>
        /// Адрес доставки
        /// </summary>
        public string Address { get; }

        /// <summary>
        /// Стоимость доставки
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Дата доставки
        /// </summary>
        public DateTime DeliveryDate { get; }

        protected Delivery()
        { }

        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="address"><inheritdoc cref="Address" path="/summary"/></param>
        protected Delivery(string address)
        {
            Address = address;
            DeliveryDate = DateTime.Now.Date;
        }

        /// <summary>
        /// Отобразить информацию о доставке
        /// </summary>
        public abstract void DisplayDeliveryInformation();
    }
}
