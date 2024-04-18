using OopPrinciples.Products;
using System.Collections.Generic;

namespace OopPrinciples.ShoppingCarts
{
    /// <summary>
    /// Корзина покупателя
    /// </summary>
    internal class ShoppingCart
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private readonly List<Product> products = new List<Product>();

        /// <summary>
        /// Предоставить список товаров
        /// </summary>
        public IReadOnlyCollection<Product> Products => products.AsReadOnly();

        /// <summary>
        /// Добавить товар в корзину
        /// </summary>
        /// <param name="product">Товар</param>
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        /// <summary>
        /// Удалить товар из корзины
        /// </summary>
        /// <param name="product">Товар</param>
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        /// <summary>
        /// Получить цену корзины
        /// </summary>
        /// <returns>Цена корзины</returns>
        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var product in products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }

        /// <summary>
        /// Очитсить коризну
        /// </summary>
        public void Clear()
        {
            products.Clear();
        }
    }
}
