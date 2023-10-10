using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siogas2.Models
{
    class ConfiguracionBase
    {
        public ConfiguracionBase()
        {

        }
    }

    
    public class HoraSistema
    {
        public HoraSistema()
        {
        }

        public string? hora_nominacion { get; set; }
        public int hora_sistema { get; set; }
        public string? hora { get; set; }
    }

    [Serializable]
    public class OperacionesPermitidas
    {
        public OperacionesPermitidas()
        {

        }

        public string? menu { get; set; }
        public string? accion { get; set; }
    }

    [Serializable]
    public class DatosConexionUsuarioRequest
    {
        public DatosConexionUsuarioRequest()
        {

        }

        public string? userName { get; set; }
        public int idSesion { get; set; }
        public string? nombre { get; set; }
        public int empresaId { get; set; }
        public string? nitEmpresa { get; set; }
        public string? nombreEmpresa { get; set; }
        public int cdsaId { get; set; }
        public string? nombreEmpresaTransportadora { get; set; }
        public string? tipoEmpresa { get; set; }
        public int gasoductoDefault { get; set; }
        public string? fechaHoraIngresoLocal { get; set; }
        public string? ipLocal { get; set; }
        public string? ipRed { get; set; }
        public string? ciudad { get; set; }
        public string? codigoRegion { get; set; }
        public string? region { get; set; }
        public string? codigoPais { get; set; }
        public string? pais { get; set; }
        public string? postal { get; set; }
        public float latitud { get; set; }
        public float longitud { get; set; }
        public string? timeZone { get; set; }
        public string? organizacion { get; set; }
        public string? asn { get; set; }
    }

    [Serializable]
    public class DatosConexionUsuario
    {
        public DatosConexionUsuario()
        {

        }

        public string? fechahora_ingreso_local { get; set; }
        public string? fechahora_ingreso_local_antes { get; set; }
        public string? fechahora_ingreso { get; set; }
        public string? fechahora_ingreso_antes { get; set; }
        public string? ip_local_antes { get; set; }
        public string? ip_red_antes { get; set; }
    }
}
