using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzeria.InputModels;
using Pizzeria.models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private ApplicationContext _db;

        public PizzasController(ApplicationContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetPizzas()
        {
            return Ok(_db.Pizzas.Select(x => new { x.Id, x.Ingredients, x.Name, x.Picture, x.Price, x.DiscountPrice}));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePizza(PizzaInputModel pizza)
        {
            Pizza newPizza;
            try
            {
                newPizza = new Pizza(pizza.Name, pizza.Ingredients, pizza.Price, pizza.Picture);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            _db.Pizzas.Add(newPizza);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        [Route("{id}/setDiscountPrice")]
        public async Task<IActionResult> SetDiscountPrice(Guid id, [FromBody] decimal discountPrice)
        {
            var pizza = _db.Pizzas.Find(id);

            if (pizza == null)
                return NotFound("Пицца не найдена");

            try
            {
                pizza.DiscountPrice = discountPrice;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
