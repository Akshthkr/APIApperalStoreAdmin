﻿using System;
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
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CategoryController(ApplicationDbContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            return await context.Categories.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category= context.Categories.Find(id);
            if(category==null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var category=context.Categories.Find(id);
            if(category==null)
            {
                return NotFound();
            }
            context.Categories.Remove(category);
            await context.SaveChangesAsync();
            return Ok(category);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Category category)
        {
            if (!ModelState.IsValid) {
                return BadRequest();
               
            }
            else
            {
                try
                {
                    context.Categories.Add(category);
                    await context.SaveChangesAsync();
                    return CreatedAtAction("Get", new { id = category.CategoryId }, category);
                    //return CreatedAtAction(nameof(Get), new { id = category.CategoryId }, category);
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
          
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int? id, [FromBody]Category c1)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else
            {
                if (id != c1.CategoryId)
                {
                    return NotFound();
                }
                context.Entry(c1).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(c1);
            }
        }

    }
}