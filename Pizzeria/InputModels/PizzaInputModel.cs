using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.InputModels
{
    /// <summary>
    /// Пицца
    /// </summary>
    public class PizzaInputModel
    {
        /// <summary>
        /// Название пиццы
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ингредиенты пиццы
        /// </summary>
        public string Ingredients { get; set; }

        /// <summary>
        /// Цена пиццы
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Фотография пиццы
        /// </summary>
        public string Picture { get; set; }
    }
}
