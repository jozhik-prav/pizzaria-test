using System;

namespace Pizzeria.models
{
    /// <summary>
    /// Пицца
    /// </summary>
    public class Pizza
    {
        /// <summary>
        /// Создает пиццу
        /// </summary>
        /// <param name="name">Название пиццы</param>
        /// <param name="ingredients">Ингредиенты пиццы</param>
        /// <param name="price">Цена пиццы</param>
        /// <param name="picture">Фотография пиццы</param>
        /// <exception cref="ArgumentNullException">Если не указано значение параметром</exception>
        /// <exception cref="ArgumentOutOfRangeException">Если цена отрицательная</exception>
        public Pizza (string name, string ingredients, decimal price, string picture)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name), "Не задано название пиццы");
            if (string.IsNullOrEmpty(ingredients))
                throw new ArgumentNullException(nameof(ingredients), "Не заданы ингредиенты пиццы");
            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price), price, "Цена пиццы не может быть отрицательной или равна 0");
            if (string.IsNullOrEmpty(picture))
                throw new ArgumentNullException(nameof(picture), "Не задана фотография пиццы");

            Id = Guid.NewGuid();
            Name = name;
            Ingredients = ingredients;
            Price = price;
            DiscountPrice = price;
            Picture = picture;
        }

        /// <summary>
        /// Идентификатор пиццы
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Название пиццы
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Ингредиенты пиццы
        /// </summary>
        public string Ingredients { get; private set; }

        /// <summary>
        /// Цена пиццы
        /// </summary>
        public decimal Price { get; private set; }

        private decimal _discountPrice;

        /// <summary>
        /// Цена со скидкой
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Если записывается неправильное значение скидки</exception>
        public decimal DiscountPrice { get => _discountPrice; set => _discountPrice = (value > 0 && value <= Price) ? value : throw new ArgumentOutOfRangeException(nameof(DiscountPrice), "Не правильное значение цены со скидкой"); }

        /// <summary>
        /// Фотография пиццы
        /// </summary>
        public string Picture { get; private set; }

    }
}
