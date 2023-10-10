using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siogas2.Models.Nominacion
{
    [Serializable]
    public class CuentaBalance
    {
        public CuentaBalance()
        {

        }
        public int Cuentas_balance_res_008_id { get; set; }
        public int Cuenta_id { get; set; }
        public string? Usuario { get; set; }
        public string? Nombre { get; set; }
        public string? Fecha_hora { get; set; }
        public int Incluido { get; set; }
        public string? Nombre2 { get; set; }

    }
}
