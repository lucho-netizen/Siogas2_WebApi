using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Siogas2.Context;
using Siogas2_webapi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace Siogas2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GasoductosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private Action<SqlServerDbContextOptionsBuilder>? connectionString;

        public GasoductosController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
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

        // GET: api/Gasoductos/
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Gasoducto>>> GetGasoducto(int id)
        {
            var gasoducto = await _context.Gasoducto.FindAsync(id);

            if (gasoducto == null)
            {
                return NotFound();
            }

            // Crea una lista que contiene el objeto Gasoducto encontrado
            var gasoductoList = new List<Gasoducto> { gasoducto };

            return gasoductoList;
        }

        // PUT: api/Gasoductos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGasoducto(int id, Gasoducto gasoducto)
        {
            if (id != gasoducto.gasoducto_id)
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

            return CreatedAtAction("GetGasoducto", new { id = gasoducto.gasoducto_id }, gasoducto);
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
            return (_context.Gasoducto?.Any(e => e.gasoducto_id == id)).GetValueOrDefault();
        }


        //Traer gasoducto por usuario
        //[ApiController]
        //[Route("api/[controller]")]
        //public class GasoductoController : ControllerBase
        //{
        //    private readonly GasoductoRepository gasoductoRepository;

        //    public GasoductoController(GasoductoRepository gasoductoRepository)
        //    {
        //        this.gasoductoRepository = gasoductoRepository;
        //    }

        //    [HttpGet]
        //    public IActionResult TraerGasoductos(string opcion, string user_name)
        //    {
        //        try
        //        {
        //            var gasoductos = gasoductoRepository.TraerGasoductos(opcion, user_name);

        //            return Ok(new Traer_Gasoductos
        //            {
        //                message = "",
        //                success = true,
        //                datos = gasoductos.ToList()
        //            });
        //        }
        //        catch (Exception e)
        //        {
        //            return BadRequest(new Traer_Gasoductos
        //            {
        //                message = "Se ha producido un error, comuníquese con soporte informático",
        //                success = false
        //            });
        //        }
        //    }
        //}

    }
}




