﻿
using System;
using System.Collections.Generic;


namespace Siogas2.Models.Nominacion
{
    
    public class EstadoNominacionTr
    {
        public EstadoNominacionTr()
        {

        }

        public int Estado_nominacion_tr_id { get; set; }
        public string? Nombre { get; set; }
        public string? Identificador { get; set; }
        public string? Descripcion { get; set; }

    }
}
