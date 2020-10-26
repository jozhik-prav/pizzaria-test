using Pizzeria.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzeria.Models
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Создает заказ
        /// </summary>
        /// <param name="orderLines">Позиции заказа</param>
        /// <exception cref="ArgumentNullException">Если нет позиций</exception>
        /// <exception cref="ArgumentOutOfRangeException">Если нет позиций</exception>
        public Order (IEnumerable<OrderLine> orderLines, DateTime date)
        {
            if (orderLines == null)
                throw new ArgumentNullException(nameof(orderLines), "Нет позиций");
            if (!orderLines.Any())
                throw new ArgumentOutOfRangeException(nameof(orderLines), "Нет позиций");

            Id = Guid.NewGuid();
            OrderLines = orderLines.ToList();
            Date = date;
        }

        private Order() { }

        /// <summary>
        /// Идентификатор заказа
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Позиции заказа
        /// </summary>
        public IReadOnlyCollection<OrderLine> OrderLines { get; private set; }

        public DateTime Date { get; private set; }
    }
    /// <summary>
    /// Строка заказа
    /// </summary>
    public class OrderLine
    {
        /// <summary>
        /// Создает позицию заказа
        /// </summary>
        /// <param name="pizzaId">Идентификатор пиццы</param>
        /// <param name="count">Количество</param>
        /// <exception cref="ArgumentOutOfRangeException">Если количество или цена меньше либо равно 0</exception>
        public OrderLine(Guid pizzaId, decimal price, int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Количество должно быть больше 0");
            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Цена пиццы не может быть отрицательной или равна 0");

            Id = Guid.NewGuid();
            PizzaId = pizzaId;
            Price = price;
            Count = count;
        }

        /// <summary>
        /// Идентификатор строки заказа
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Пицца
        /// </summary>
        public Pizza Pizza { get; private set; }

        /// <summary>
        /// Идентификатор пиццы
        /// </summary>
        public Guid PizzaId { get; private set; }

        /// <summary>
        /// Цена на момент заказа
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; private set; } 
    }
}
