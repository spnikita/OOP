namespace OopPrinciples.Products
{
    /// <summary>
    /// Товар
    /// </summary>
    internal class Product
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Цена товара
        /// </summary>
        public decimal Price { get; }

        private Product()
        { }
        
        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="name"><inheritdoc cref="Name" path="/summary"/></param>
        /// <param name="price"><inheritdoc cref="Price" path="/summary"/></param>
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
