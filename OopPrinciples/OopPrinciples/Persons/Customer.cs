using OopPrinciples.Products;
using OopPrinciples.ShoppingCarts;
using System.Collections.Generic;

namespace OopPrinciples.Persons
{
    /// <summary>
    /// Покупатель
    /// </summary>
    internal class Customer : Person
    {       
        /// <summary>
        /// Реквизиты платежной карты
        /// </summary>
        public string ChargeCard = string.Empty;
        
        /// <summary>
        /// Корзина товаров
        /// </summary>
        private readonly ShoppingCart _cart;

        private Customer()
        { }

        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="name"><inheritdoc cref="Person(string, string, string)" path="/param[@name='name']"/></param>
        /// <param name="lastName"><inheritdoc cref="Person(string, string, string)" path="/param[@name='lastName']"/></param>
        /// <param name="phoneNumber"><inheritdoc cref="Person(string, string, string)" path="/param[@name='phoneNumber']"/></param>
        /// <param name="cart"><inheritdoc cref="_cart" path="/summary"/></param>
        public Customer(string name, string lastName, string phoneNumber, ShoppingCart cart) : base(name, lastName, phoneNumber)
        {          
            _cart = cart;
        }

        /// <summary>
        /// Добавить товар в корзину
        /// </summary>
        /// <param name="product">Товар</param>
        public void AddProductToCart(Product product)
        {
            _cart.AddProduct(product);
        }

        /// <summary>
        /// Добавить товары в корзину
        /// </summary>
        /// <param name="product">Товары</param>
        public void AddProductToCart(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                _cart.AddProduct(product);
            }           
        }

        /// <summary>
        /// Удалить товар из корзины
        /// </summary>
        /// <param name="product">Товар</param>
        public void RemoveProductFromCart(Product product)
        {
            _cart.RemoveProduct(product);
        }

        /// <summary>
        /// Получить список покуппаемых товаров
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<Product> GetCartProducts()
        {
            return _cart.Products;
        }

        /// <summary>
        /// Получить стоимость корзины
        /// </summary>
        /// <returns>Стоимость корзины</returns>
        public decimal GetCartPrice()
        {
            return _cart.CalculateTotalPrice();
        }

        /// <summary>
        /// Очитсить корзину
        /// </summary>
        public void ClearCart()
        {
            _cart.Clear();
        }
    }
}
