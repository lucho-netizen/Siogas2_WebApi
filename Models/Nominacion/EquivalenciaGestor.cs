using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siogas2.Models.Nominacion
{
    [Serializable]
    public class EquivalenciaGestor
    {
        public EquivalenciaGestor()
        {

        }

        public int Id_equivalencia { get; set; }
        public int Id_distribuidor { get; set; }
        public string? Nombre_distribuidor { get; set; }
        public int Id_punto_salida { get; set; }
        public string? Nombre_punto_salida { get; set; }
        public int Id_consumidor { get; set; }
        public string? Nombre_consumidor { get; set; }
        public int Tipo_mercado { get; set; }
        public string? Nombre_tipo_mercado { get; set; }
        public int Id_punto_salida_recibe { get; set; }
        public string? Nombre_punto_salida_recibe { get; set; }
        public string? Usuario { get; set; }
        public int Gasoducto_id { get; set; }
        public string? Fecha_hora { get; set; }

    }
}
