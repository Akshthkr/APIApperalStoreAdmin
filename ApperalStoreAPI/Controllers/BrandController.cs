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
    public class BrandController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public BrandController(ApplicationDbContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Brand> b= await context.Brands.ToListAsync();
            return Ok(b);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            try
            {
                var brand = context.Brands.Find(id);
                if (brand == null)
                {
                    return NotFound();
                }
                return Ok(brand);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var brand = context.Brands.Find(id);
            if (brand == null)
            {
                return NotFound();
            }
            context.Brands.Remove(brand);
            await context.SaveChangesAsync();
            return Ok(brand);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                try
                {
                    context.Brands.Add(brand);
                    await context.SaveChangesAsync();
                    //return CreatedAtAction(nameof(Get), new { id = brand.BrandId }, brand);
                    return CreatedAtAction("Get", new { id = brand.BrandId }, brand);
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int? id, [FromBody]Brand b1)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else
            {
                if (id != b1.BrandId)
                {
                    return NotFound();
                }
                context.Entry(b1).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(b1);

            }
        }
    }
}