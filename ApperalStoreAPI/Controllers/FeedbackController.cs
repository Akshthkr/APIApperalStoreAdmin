using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApperalStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApperalStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public FeedbackController(ApplicationDbContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Feedback>>> Get()
        {
            return await context.Feedbacks.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Feedback>> Get(int id)
        {
            var feedback = context.Feedbacks.Find(id);
            if (feedback == null)
            {
                return NoContent();
            }
            return feedback;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Feedback>> Delete(int id)
        {
            var feeddback = context.Feedbacks.Find(id);
            if (feeddback == null)
            {
                return NotFound();
            }
            context.Feedbacks.Remove(feeddback);
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Feedback>> Post([FromBody]Feedback feedback)
        {
            context.Feedbacks.Add(feedback);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = feedback.FeedbackId }, feedback);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Feedback>> Put(int id, [FromBody]Feedback c1)
        {
            if (id != c1.FeedbackId)
            {
                return BadRequest();
            }
            context.Entry(c1).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}