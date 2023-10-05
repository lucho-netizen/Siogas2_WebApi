using System;

namespace Siogas2.Models.Parametrizacion
{
    public class ClienteReventa
    {
        public ClienteReventa()
        {
        }

        public int Cliente_reventa_id { get; set; }
        public int Cliente_id { get; set; }
        public string? Razon_social { get; set; }
        public string? Sigla { get; set; }
    }

    
    public class ClienteReventaSerializable
    {
        public ClienteReventaSerializable()
        {

        }

        public int Cliente_reventa_id { get; set; }
        public int Cliente_id { get; set; }
        public string? Razon_social { get; set; }
        public string? Sigla { get; set; }
    }
}
