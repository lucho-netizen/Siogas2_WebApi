using Siogas2_webapi.Models;

namespace Siogas2_WebApi.Controllers
{
    internal class Traer_Gasoductos
    {
        public string? message { get; set; }
        public bool success { get; set; }
        public List<Gasoducto>? datos { get; set; }
    }
}