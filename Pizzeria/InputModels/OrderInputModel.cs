using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.InputModels
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class OrderInputModel
    {
        /// <summary>
        /// Позиции заказа
        /// </summary>
        public IEnumerable<OrderLineInputModel> OrderLines { get; set; }
    }

    /// <summary>
    /// Строка заказа
    /// </summary>
    public class OrderLineInputModel
    {
        /// <summary>
        /// Идентификатор пиццы
        /// </summary>
        public Guid PizzaId { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
    }
}
