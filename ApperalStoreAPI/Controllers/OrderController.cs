using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApperalStoreAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApperalStoreAPI.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly ApplicationDbContext context;

        public OrderController(ApplicationDbContext _context)
        {
            context = _context;
        }
        [HttpGet]
            public async Task<ActionResult<IEnumerable<Order>>> Get()
            {
                return await context.Orders.ToListAsync();
            }
            [HttpGet("{id}")]
            public async Task<ActionResult<Order>> Get(int id)
            {
                var order = context.Orders.Find(id);
                if (order == null)
                {
                    return NoContent();
                }
                return order;
            }
            [HttpDelete("{id}")]
            public async Task<ActionResult<Order>> Delete(int id)
            {
                var order = context.Orders.Find(id);
                if (order == null)
                {
                    return NotFound();
                }
                context.Orders.Remove(order);
                await context.SaveChangesAsync();
                return NoContent();
            }
            [HttpPost]
            public async Task<ActionResult<Order>> Post([FromBody]Order order)
            {
                context.Orders.Add(order);
                await context.SaveChangesAsync();
                return CreatedAtAction(nameof(Get), new { id = order.OrderId }, order);
            }
            [HttpPut("{id}")]
            public async Task<ActionResult<Order>> Put(int id, [FromBody]Order o1)
            {
                if (id != o1.OrderId)
                {
                    return BadRequest();
                }
                context.Entry(o1).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return NoContent();
            }
        }
}