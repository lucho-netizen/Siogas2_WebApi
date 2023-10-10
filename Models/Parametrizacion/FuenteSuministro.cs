using System;

namespace Siogas2.Models.Parametrizacion
{
    
    public class FuenteSuministro
    {
        public FuenteSuministro()
        {

        }

        public int Campo_productor_id { get; set; }
        public string? Nombre { get; set; }
        public int Ubicacion_pais_id { get; set; }
        public string? Ubicacion_pais { get; set; }
        public int Ubicacion_departamento_id { get; set; }
        public string? Ubicacion_departamento { get; set; }
        public int Ubicacion_municipio_id { get; set; }
        public string? Ubicacion_municipio { get; set; }
        public string? Ubicacion_longitud { get; set; }
        public string? Ubicacion_latitud { get; set; }
        public bool Activo { get; set; }
        public int Tramo_id { get; set; }
        public string? Tramo { get; set; }
        public bool Nominacion { get; set; }
        public bool Oba { get; set; }
    }

    
    public class PuntoInicial
    {
        public PuntoInicial()
        {

        }

        public int Punto_inicial_servicio_id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public int Orden { get; set; }
    }

    
    public class Campo_productor_lista
    {
        public Campo_productor_lista()
        {

        }
        public int Es_nodo { get; set; }
        public int Campo_productor_id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo_pis { get; set; }
    }
}
