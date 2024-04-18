using OopPrinciples.Persons;
using OopPrinciples.Products;
using System;
using System.Collections.Generic;
using OopPrinciples.Enums;
using System.Linq;

namespace OopPrinciples.Order
{
    /// <summary>
    /// Заказ
    /// </summary>
    internal class Order<TDelivery> where TDelivery : Delivery.Delivery
    {
        /// <summary>
        /// Номер заказа
        /// </summary>
        public string OrderNumber { get; } = Guid.NewGuid().ToString();
        
        /// <summary>
        /// Доставка
        /// </summary>
        private readonly TDelivery _delivery;

        /// <summary>
        /// Дата-время заказа
        /// </summary>
        public DateTime OrderDateTime { get; }

        /// <summary>
        /// Имя покупателя
        /// </summary>
        public string CustomerName { get; }

        /// <summary>
        /// Фамилия покупателя
        /// </summary>
        public string CustomerLastName { get; }

        /// <summary>
        /// Телефон покупателя
        /// </summary>
        public string CustomerPhoneNumber { get; }

        /// <summary>
        /// Стоимость корзины
        /// </summary>
        public decimal CartPrice { get; }

        /// <summary>
        /// Итоговый заказ
        /// </summary>
        private readonly List<Product> _productList = new List<Product>();

        /// <summary>
        /// <inheritdoc cref="_productList" path="/summary"/>
        /// </summary>
        public IReadOnlyCollection<Product> ProductList 
        { 
            get => _productList.AsReadOnly();
            set
            {
                if (!_productList.Any())
                {
                    foreach (var product in value)
                        _productList.Add(product);
                }
            } 
        }

        /// <summary>
        /// Адрес доставки
        /// </summary>
        protected string DeliveryAddress => _delivery.Address;

        /// <summary>
        /// Стоимость доставки
        /// </summary>
        protected decimal DeliveryPrice => _delivery.Price;

        /// <summary>
        /// Статус заказа
        /// </summary>
        private OrderStatus _orderStatus;

        /// <summary>
        /// <inheritdoc cref="_orderStatus" path="/summary"/>
        /// </summary>
        public OrderStatus OrderStatus => _orderStatus;

        private Order()
        { }

        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="customer"><inheritdoc cref="_customer" path="/summary"/></param>
        /// <param name="delivery"><inheritdoc cref="_delivery" path="/summary"/></param>
        public Order(Customer customer, TDelivery delivery)
        {           
            CustomerName = customer.Name;
            CustomerLastName = customer.LastName;
            CustomerPhoneNumber = customer.PhoneNumber;
            ProductList = customer.GetCartProducts();
            CartPrice = customer.GetCartPrice();
            customer.ClearCart();

            _delivery = delivery;

            OrderDateTime = DateTime.Now;
            _orderStatus = OrderStatus.Created;
        }        

        /// <summary>
        /// Получить итоговую стоимость заказа
        /// </summary>
        /// <returns>Стоимость заказа</returns>
        public decimal CalculateTotalPrice()
        {
            return CartPrice + DeliveryPrice;
        }

        /// <summary>
        /// Сменить статус заказа
        /// </summary>
        /// <param name="orderStatus">Статус заказа</param>
        public void ChangeOrderStatus(OrderStatus orderStatus)
        {
            _orderStatus = orderStatus;
        }

        /// <summary>
        /// Отобразить информацию о доставке
        /// </summary>
        public void DisplayDeliveryInformation()
        {
            _delivery.DisplayDeliveryInformation();
        }

        /// <summary>
        /// Отобразить информацию о заказе
        /// </summary>
        public void DisplayOrderInformation()
        {
            Console.WriteLine("Заказ №{0}", OrderNumber);
            Console.WriteLine("Дата-время заказа: {0}", OrderDateTime.ToString("F"));
            Console.WriteLine("Адрес доставки: {0}", DeliveryAddress);
            Console.WriteLine("Получатель: {0} {1}", CustomerName, CustomerLastName);
            Console.WriteLine("Телефон получателя: {0}", CustomerPhoneNumber);
            Console.WriteLine("Количество товаров: {0}", ProductList.Count);

            var i = 0;
            foreach (var product in ProductList)
            {
                Console.WriteLine("\nТовар №{0}", ++i);
                Console.WriteLine("\tНаименование: {0}", product.Name);
                Console.WriteLine("\tСтоимость: {0}", product.Price);
            }

            Console.WriteLine("\nОбщая стоимость товаров: {0}", CartPrice);
            Console.WriteLine("Стоимость доставки: {0}", DeliveryPrice);
            Console.WriteLine("Общая стоимость заказа: {0}", CalculateTotalPrice());
            Console.WriteLine("Текущий статус заказа: {0}", OrderStatus);
        }
    }
}
