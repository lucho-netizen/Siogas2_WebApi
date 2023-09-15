using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Siogas2_WebApi.Context;
using Siogas2_webapi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Siogas2_WebApi.Controllers
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


        //Traer gasoducto por usuario
        [HttpGet("TraerGasoductos")]
        public IActionResult TraerGasoductos(string opcion, string user_name, Gasoducto gasoducto)
        {
            try
            {
                

                string sql;
                if (opcion == "MOVIL")
                {
                    sql = "select distinct u.gasoducto_id, g.nombre ";
                    sql += "from usuario_gasoducto u inner join gasoducto g ";
                    sql += "on u.gasoducto_id=g.gasoducto_id ";
                    sql += "where usuario_username='" + user_name + "' ";
                }
                else
                {
                    sql = "select g.gasoducto_id, g.nombre ";
                    sql += "from usuario_opcion_gasoductos u, gasoducto g ";
                    sql += "where u.gasoducto_id = g.gasoducto_id ";
                    sql += "and u.usuario = '" + user_name + "' ";
                    sql += "and u.opcion = '" + opcion + "'";
                }

                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
                {
                    var consulta = dbContext.Gasoducto.FromSqlRaw(sql).ToList();

                    List<Gasoducto> listado = new List<Gasoducto>();
                    foreach (var registro in consulta)
                    {
                        Gasoducto elemento = new Gasoducto
                        {
                            Gasoducto_id = registro.Gasoducto_id,
                            Nombre = registro.Nombre
                        };
                        listado.Add(elemento);
                    }

                    return Ok(new Traer_Gasoductos
                    {
                        message = "",
                        success = true,
                        datos = listado
                    });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new Traer_Gasoductos
                {
                    message = "Se ha producido un error, comuníquese con soporte informático",
                    success = false
                });
            }
        }
    }
}




