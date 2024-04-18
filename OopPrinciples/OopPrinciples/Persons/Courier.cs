namespace OopPrinciples.Persons
{
    /// <summary>
    /// Курьер
    /// </summary>
    internal class Courier : Person
    {              
        /// <summary>
        /// Номер автомобиля
        /// </summary>
        public string CarNumber { get; }

        private Courier()
        { }

        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="name"><inheritdoc cref="Person(string, string, string)" path="/param[@name='name']"/></param>
        /// <param name="lastName"><inheritdoc cref="Person(string, string, string)" path="/param[@name='lastName']"/></param>
        /// <param name="phoneNumber"><inheritdoc cref="Person(string, string, string)" path="/param[@name='phoneNumber']"/></param>
        /// <param name="carNumber"><inheritdoc cref="CarNumber" path="/summary"/></param>
        public Courier(string name, string lastName, string phoneNumber, string carNumber) : base (name, lastName, phoneNumber)
        {
            CarNumber = carNumber;
        }
    }
}
