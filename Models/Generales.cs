using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Siogas2.Models
{
    public class Generales
    {

        public string ObtenerRutaArchivos()
        {
            string sRuta = $"{Environment.CurrentDirectory}\\File\\";
            return sRuta;
        }
        public string? ObtenerRutaArchivosXml { get; set; }
        public string? ObtenerUsuario { get; set; }
        //public IFormFile ObtenerArchivo { get; set; }

    }
}