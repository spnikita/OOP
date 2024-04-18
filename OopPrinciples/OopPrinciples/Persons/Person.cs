namespace OopPrinciples.Persons
{
    /// <summary>
    /// Абстрактный класс человека
    /// </summary>
    internal abstract class Person
    {
        /// <summary>
        /// Имя покупателя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Фамилия покупателя
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Телефонный номер покупателя
        /// </summary>
        public string PhoneNumber { get; }

        protected Person()
        { }

        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="name"><inheritdoc cref="Name" path="/summary"/></param>
        /// <param name="lastName"><inheritdoc cref="LastName" path="/summary"/></param>
        /// <param name="phoneNumber"><inheritdoc cref="PhoneNumber" path="/summary"/></param>
        protected Person(string name, string lastName, string phoneNumber)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;           
        }
    }
}
