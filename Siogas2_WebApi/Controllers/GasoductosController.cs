using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Siogas2_WebApi.Context;
using Siogas2_webapi.Models;

namespace Siogas2_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GasoductosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GasoductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Gasoductos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gasoducto>>> GetGasoducto()
        {
          if (_context.Gasoducto == null)
          {
              return NotFound();
          }
            return await _context.Gasoducto.ToListAsync();
        }

        // GET: api/Gasoductos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gasoducto>> GetGasoducto(int id)
        {
          if (_context.Gasoducto == null)
          {
              return NotFound();
          }
            var gasoducto = await _context.Gasoducto.FindAsync(id);

            if (gasoducto == null)
            {
                return NotFound();
            }

            return gasoducto;
        }

        // PUT: api/Gasoductos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGasoducto(int id, Gasoducto gasoducto)
        {
            if (id != gasoducto.Gasoducto_id)
            {
                return BadRequest();
            }

            _context.Entry(gasoducto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GasoductoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Gasoductos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Gasoducto>> PostGasoducto(Gasoducto gasoducto)
        {
          if (_context.Gasoducto == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Gasoducto'  is null.");
          }
            _context.Gasoducto.Add(gasoducto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGasoducto", new { id = gasoducto.Gasoducto_id }, gasoducto);
        }

        // DELETE: api/Gasoductos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGasoducto(int id)
        {
            if (_context.Gasoducto == null)
            {
                return NotFound();
            }
            var gasoducto = await _context.Gasoducto.FindAsync(id);
            if (gasoducto == null)
            {
                return NotFound();
            }

            _context.Gasoducto.Remove(gasoducto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GasoductoExists(int id)
        {
            return (_context.Gasoducto?.Any(e => e.Gasoducto_id == id)).GetValueOrDefault();
        }
    }
}
