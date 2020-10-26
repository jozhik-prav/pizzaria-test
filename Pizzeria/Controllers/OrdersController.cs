using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.InputModels;
using Pizzeria.models;
using Pizzeria.Models;
using System.Security.Cryptography.X509Certificates;

namespace Pizzeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private ApplicationContext _db;

        public OrdersController(ApplicationContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok( _db.Orders.Select(x => new { 
                x.Date,
                x.Id, 
                OrderLines = x.OrderLines.Select(y => new { PizzaName = y.Pizza.Name, y.Count, y.Price })
            }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderInputModel order)
        {
            IEnumerable<OrderLine> orderLines;
            var pizzas =  _db.Pizzas.Select(x => new {x.Id, x.Price, x.DiscountPrice });
            try
            {
                orderLines = order.OrderLines.Select(x => new OrderLine(x.PizzaId, pizzas.FirstOrDefault(y => y.Id == x.PizzaId)?.DiscountPrice ?? 0, x.Count)) ?? new List<OrderLine>();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            Order newOrder;
            try
            {
                newOrder = new Order(orderLines, DateTime.Now);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            _db.Orders.Add(newOrder);
            await _db.SaveChangesAsync();
            return Ok(newOrder.Id);
        }
    }
}
