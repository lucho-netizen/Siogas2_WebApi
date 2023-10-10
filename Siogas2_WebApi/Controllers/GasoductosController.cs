using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Models;
using Siogas2.LogicInterfaces.Parametrizacion;
using Siogas2.Resources;
using Siogas2.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Siogas2_WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class GasoductoController : ControllerBase
    {
        private readonly IGasoductoManager gasoductoManager;
        private readonly IConfiguration configuration;
        private readonly ILogger<GasoductoController> logger;

        public GasoductoController(IGasoductoManager gasoductoManager, IConfiguration configuration, ILogger<GasoductoController> logger)
        {
            this.gasoductoManager = gasoductoManager;
            this.configuration = configuration;
            this.logger = logger;
        }

        // GET: api/<GasoductosController>
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_INICIAR_SERVICIO, "Get", this.GetType().FullName));

                IEnumerable<Gasoducto> lista = this.gasoductoManager.GetAll();

                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_FIN_SERVICIO, "Get", this.GetType().FullName));

                return Ok(lista);
            }
            catch (SqlException ex)
            {
                this.logger.LogError(string.Format(MessagesLogger.LOGGER_ERROR_SERVICIO, "Get", this.GetType().FullName, ex.Message));

                return NotFound(new { message = ex.Message, success = false });
            }
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            try
            {
                this.logger.LogInformation(String.Format(MessagesLogger.LOGGER_INICIAR_SERVICIO, "Get", this.GetType().FullName));

                Gasoducto gasoducto = this.gasoductoManager.Get(id);
                List<Gasoducto> lista = new List<Gasoducto>();
                lista.Add(gasoducto);

                this.logger.LogInformation(String.Format(MessagesLogger.LOGGER_FIN_SERVICIO, "Get", this.GetType().FullName));

                return Ok(lista);
            }
            catch (SqlException ex)
            {
                this.logger.LogError(String.Format(MessagesLogger.LOGGER_ERROR_SERVICIO, "Get", this.GetType().FullName, ex.Message));

                return NotFound(new { message = ex.Message, success = false });
            }
        }

        // GET api/<GasoductosController>/5
        [HttpGet("{opcion}/{userName}")]

        public IActionResult Get(string opcion, string userName)
        {
            try
            {
                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_INICIAR_SERVICIO, "Get", this.GetType().FullName));

                IEnumerable<GasoductoOptionUser> lista = this.gasoductoManager.GetByOptionUser(opcion, userName);

                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_FIN_SERVICIO, "Get", this.GetType().FullName));

                return Ok(lista);
            }
            catch (SqlException ex)
            {
                this.logger.LogError(string.Format(MessagesLogger.LOGGER_ERROR_SERVICIO, "Get", this.GetType().FullName, ex.Message));

                return NotFound(new { message = ex.Message, success = false });
            }
        }

        // POST api/<GasoductosController>
        [HttpPost]

        public IActionResult Post([FromBody] Gasoducto dato)
        {
            try
            {
                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_INICIAR_SERVICIO, "Post", this.GetType().FullName));

                this.gasoductoManager.Save(dato);

                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_FIN_SERVICIO, "Post", this.GetType().FullName));

                return Ok(new { message = MessagesApp._200_INFO_ADICIONAR, success = true });
            }
            catch (SqlException ex)
            {
                this.logger.LogError(string.Format(MessagesLogger.LOGGER_ERROR_SERVICIO, "Post", this.GetType().FullName, ex.Message));

                return NotFound(new { message = ex.Message, success = false });
            }
        }

        // PUT api/<GasoductosController>/5
        [HttpPut]

        public IActionResult Put([FromBody] Gasoducto dato)
        {
            try
            {
                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_INICIAR_SERVICIO, "Put", this.GetType().FullName));

                this.gasoductoManager.Save(dato);

                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_FIN_SERVICIO, "Put", this.GetType().FullName));

                return Ok(new { message = MessagesApp._200_INFO_ACTUALIZAR, success = true });
            }
            catch (SqlException ex)
            {
                this.logger.LogError(string.Format(MessagesLogger.LOGGER_ERROR_SERVICIO, "Put", this.GetType().FullName, ex.Message));

                return NotFound(new { message = ex.Message, success = false });
            }
        }

        // DELETE api/<GasoductosController>/5
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_INICIAR_SERVICIO, "Delete", this.GetType().FullName));

                this.gasoductoManager.Remove(id);

                this.logger.LogInformation(string.Format(MessagesLogger.LOGGER_FIN_SERVICIO, "Delete", this.GetType().FullName));

                return Ok(new { message = MessagesApp._200_INFO_ELIMINAR, success = true });
            }
            catch (SqlException ex)
            {
                this.logger.LogError(string.Format(MessagesLogger.LOGGER_ERROR_SERVICIO, "Delete", this.GetType().FullName, ex.Message));

                return NotFound(new { message = ex.Message, success = false });
            }
        }
    }
}
