using System;

namespace Models
{
    [Serializable]
    public class Gasoducto
    {
        public Gasoducto()
        {
        }

        public int gasoducto_id { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }
        public int empresa_transportadora_id { get; set; }
        public string? razon_social { get; set; }
        public int ubicacion_extremo_inicial_pais_id { get; set; }
        public string? pais_extremo_inicial { get; set; }
        public int ubicacion_extremo_inicial_departamento_id { get; set; }
        public string? departamento_extremo_inicial { get; set; }
        public int ubicacion_extremo_inicial_municipio_id { get; set; }
        public string? municipio_extremo_inicial { get; set; }
        public string? ubicacion_extremo_inicial_longitud { get; set; }
        public string? ubicacion_extremo_inicial_latitud { get; set; }
        public int ubicacion_extremo_final_pais_id { get; set; }
        public string? pais_extremo_final { get; set; }
        public int ubicacion_extremo_final_departamento_id { get; set; }
        public string? departamento_extremo_final { get; set; }
        public int ubicacion_extremo_final_municipio_id { get; set; }
        public string? municipio_extremo_final { get; set; }
        public string? ubicacion_extremo_final_longitud { get; set; }
        public string? ubicacion_extremo_final_latitud { get; set; }
    }

    [Serializable]
    public class GasoductoOptionUser
    {
        public GasoductoOptionUser()
        {
        }

        public int gasoducto_id { get; }
        public string? nombre { get; }
    }
}
