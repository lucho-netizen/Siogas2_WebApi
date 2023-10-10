using System;

namespace Siogas2.Models.Parametrizacion
{
    
    public class Cliente
    {
        public Cliente()
        {

        }

        public int cliente_id { get; set; }
        public string razon_social { get; set; }
        public string nit { get; set; }
        public string sigla { get; set; }
        public int tipo_sociedad_id { get; set; }
        public string nombre_tipo_sociedad { get; set; }
        public int empresa_transportador_id { get; set; }
        public string nombre_empresa_transportadora { get; set; }
        public int pais_id { get; set; }
        public string nombre_pais { get; set; }
        public int departamento_id { get; set; }
        public string nombre_departamento { get; set; }
        public int municipio_id { get; set; }
        public string nombre_municipio { get; set; }
        public bool activo { get; set; }
    }
}
