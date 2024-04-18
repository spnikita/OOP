namespace OopPrinciples.Enums
{
    /// <summary>
    /// Статусы заказа
    /// </summary>
    internal enum OrderStatus
    {
        /// <summary>
        /// Заказ создан
        /// </summary>
        Created,
        
        /// <summary>
        /// Заказ передан в доставку
        /// </summary>
        SentForDelivery,

        /// <summary>
        /// Заказ доставляется
        /// </summary>
        BeingDelivered,
        
        /// <summary>
        /// Заказ получен
        /// </summary>
        Received
    }
}
