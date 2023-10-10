using System;
using System.Collections.Generic;

namespace Siogas2.Models.Parametrizacion
{ 
    public class Nodo
    {
        public Nodo()
        {

        }

        public int Nodo_id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cliente_id { get; set; }
        public string? Nombre_cliente { get; set; }
        public int Contrato_id { get; set; }
        public string? Codigo_contrato { get; set; }
        public int Campo_productor_id { get; set; }
        public string? Nombre_campo_productor { get; set; }
        public bool Activo { get; set; }
        public int Gasoducto_id { get; set; }
        public string? Nombre_gasoducto { get; set; }
        public int Tramo_id { get; set; }
        public string? Nombre_tramo { get; set; }
        public bool Literal_a { get; set; }
        public bool Literal_c { get; set; }
        public float Volumen { get; set; }
        public bool Prevalece { get; set; }
        public string? Comentario { get; set; }
    }

    
    public class PuntoFinal
    {
        public PuntoFinal()
        {

        }

        public int Punto_final_servicio_id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public int Orden { get; set; }
    }



}
