using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzeria.InputModels;
using Pizzeria.models;
using System;
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
            return Ok(await _db.Pizzas.ToListAsync());
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
    }
}
