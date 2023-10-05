using System;
using System.Collections.Generic;

namespace Siogas2.Models.Nominacion
{
    [Serializable]
    public class NominacionInfo
    {
        public NominacionInfo()
        {

        }

        public int Nominacion_transporte_id { get; set; }
        public int Cliente_id { get; set; }
        public int Remitente_id { get; set; }
        public string Remitente { get; set; }
        public int Reemplazante_id { get; set; }
        public string Reemplazante { get; set; }
        public int Nodo_id { get; set; }
        public int Tipo_uso_id { get; set; }
        public int Mercado_id { get; set; }
        public string Nodo { get; set; }
        public int Variable_nominacion_id { get; set; }
        public string Tipo_nominacion { get; set; }
        public string? Variable_nominacion { get; set; }
        public int Fuente_suministro_id { get; set; }
        public string? Fuente_suministro { get; set; }
        public string? Fecha_nominacion { get; set; }
        public float Valor_mbtu { get; set; }
        public float Valor_kpc { get; set; }
        public string? Estado_identificador { get; set; }
        public string? Estado { get; set; }
        public string? Dia_nominado { get; set; }
        public string? Tipo_pis { get; set; }
        public string? Tipo_pfs { get; set; }
        public int Contrato_id { get; set; }
        public string? Contrato { get; set; }
        public string? Mercado { get; set; }
        public string? Tipo_uso { get; set; }

    }
    [Serializable]
    public class Valores_proveedores
    {
        public int Nominacion_transporte_id { get; set; }
        public string? Estado_identificador { get; set; }
        public double Valor_mbtu { get; set; }
        public int Cliente_id { get; set; }
        public string? Razon_social { get; set; }
    }
    public class ListaTrazabilidad
    {
        public ListaTrazabilidad()
        {

        }
        public string? Cliente { get; set; }
        public string? Remitente { get; set; }
        public string? Nodo { get; set; }
        public string? Fuente_suministro { get; set; }
        public string? Estado_identificador { get; set; }
        public double Valor_mbtu { get; set; }
        public string? Usuario { get; set; }
        public string? Fecha_actualizacion { get; set; }
        public string? Tipo_uso { get; set; }
        public string? Mercado { get; set; }
    }

    public class ListaNominacionHoraria
    {
        public ListaNominacionHoraria()
        {
        }
        public int Nominacion_transporte_hora_id { get; set; }
        public int Nominacion_transporte_id { get; set; }
        public string? Hora { get; set; }
        public double Valor_mbtu { get; set; }
        public string? Usuario { get; set; }
        public int Conteo { get; set; }
    }
    public class ListaNominacionDuplicada
    {

        public ListaNominacionDuplicada()
        {

        }

        public int Nominacion_transporte_id;
        public string? Dia_nominado;
        public int Fuente_suministro_id;
        public int Nodo_id;
        public int Cliente_id;
        public int Remitente_id;
        public int Variable_nominacion_id;
        public double Valor_mbtu;
        public string? Estado_identificador;
        public string? Tipo_nominacion;
        public int Contrato_id;
        public double Poder_calorifico_vigente;
        public int Tipo_uso_id;
        public int Mercado_id;
        public string Fecha_actualizacion;
        public string? Tipo_pis;
        public string? Tipo_pfs;
        public string? Pis;
        public string? Pfs;
        public string? Remitente;
        public string? Reemplazante;
        public string? Variable_nominacion;
        public string? Contrato;
        public string? Tipo_uso;
        public string? Mercado;
        public string? Resalte;
        public int Automatico;
    }

    public class ListaDuplicadosEliminados
    {
        public ListaDuplicadosEliminados()
        {

        }

        public int Nominacion_transporte_id;
        public string? Dia_nominado;
        public int Fuente_suministro_id;
        public int Nodo_id;
        public int Cliente_id;
        public int Remitente_id;
        public int Variable_nominacion_id;
        public double Valor_mbtu;
        public string? Estado_identificador;
        public string? Tipo_nominacion;
        public int Contrato_id;
        public double Poder_calorifico_vigente;
        public int Tipo_uso_id;
        public int Mercado_id;
        public string? Usuario;
        public string? Fecha_actualizacion;
        public string? Tipo_pis;
        public string? Tipo_pfs;
        public string? Pis;
        public string? Pfs;
        public string? Remitente;
        public string? Reemplazante;
        public string? Variable_nominacion;
        public string? Contrato;
        public string? Tipo_uso;
        public string? Mercado;
        public string? Usuario_registro;
        public string? Fecha_hora_registro;
        public string? Comentario_registro;
        public string? Usuario_registro_restaura;
        public string? Fecha_hora_registro_restaura;
        public string? Comentario_registro_restaura;
        public string? Estado;
    }

    
    public class EliminacionDuplicadosNominacionRequest
    {
        public EliminacionDuplicadosNominacionRequest()
        {

        }

        public List<int> Lista { get; set; }
        public List<string>? Comentario { get; set; }
        public List<string>? Usuario { get; set; }
    }

    [Serializable]
    public class RevertireliminacionDuplicadosNominacionRequest
    {
        public RevertireliminacionDuplicadosNominacionRequest()
        {

        }

        public List<int> Lista { get; set; }
        public List<string>? Comentario { get; set; }
        public List<string>? Usuario { get; set; }
    }

    
    public class Lista_NominacionPs008
    {
        public Lista_NominacionPs008()
        {

        }

        public int Nominacion_transporte_id { get; set; }
        public string? Dia_nominado { get; set; }
        public int Fuente_suministro_id { get; set; }
        public int Nodo_id { get; set; }
        public int Cliente_id { get; set; }
        public int Remitente_id { get; set; }
        public int Variable_nominacion_id { get; set; }
        public double Valor_mbtu { get; set; }
        public string? Estado_identificador { get; set; }
        public string? Tipo_nominacion { get; set; }
        public int Contrato_id { get; set; }
        public double Poder_calorifico_vigente { get; set; }
        public int Tipo_uso_id { get; set; }
        public int Mercado_id { get; set; }
        public string? Usuario { get; set; }
        public string? Fecha_actualizacion { get; set; }
        public string? Tipo_pis { get; set; }
        public string? Tipo_pfs { get; set; }
        public string? Pis { get; set; }
        public string? Pfs { get; set; }
        public string? Remitente { get; set; }
        public string? Reemplazante { get; set; }
        public string? Variable_nominacion { get; set; }
        public string? Contrato { get; set; }
        public string? Tipo_uso { get; set; }
        public string? Mercado { get; set; }
        public string? Resalte { get; set; }
        public int Automatico { get; set; }
    }

    
    public class EliminacionAsignacionRequest
    {
        public EliminacionAsignacionRequest()
        {

        }
        public List<string>? Dia { get; set; }
        public List<int> Nodo { get; set; }
        public List<int> Remitente { get; set; }
        public List<int> Contrato { get; set; }
        public List<int> Reemplazante { get; set; }
        public List<int> Fuente_suministro { get; set; }
        public List<int> Mercado { get; set; }
        public List<int> Tipo_uso { get; set; }
        public List<int> Valor_mbtu { get; set; }
        public List<int> Variable_id { get; set; }

    }

    
    public class FuentesAsignacion
    {
        public FuentesAsignacion()
        {

        }
        public int Campo_productor_id { get; set; }
        public string? Nombre { get; set; }
        public double Valor_mbtu { get; set; }
        public string? Usuario { get; set; }
        public string? Comentario { get; set; }
    }
    [Serializable]
    public class ComentarioAsignacion
    {
        public ComentarioAsignacion()
        {

        }
        public string? Comentario { get; set; }
    }

    [Serializable]
    public class AsignacionFuente
    {
        public AsignacionFuente()
        {

        }
        public NominacionAsignacion[] Nominacion { get; set; }
        public FuentesAsignacion[] Reparticion { get; set; }
    }

    
    public class NominacionAsignacion
    {
        public NominacionAsignacion()
        {

        }
        public string? Dia { get; set; }
        public int Nodo { get; set; }
        public int Remitente { get; set; }
        public int Contrato { get; set; }
        public int Reemplazante { get; set; }
        public int Fuente_suministro { get; set; }
        public int Mercado { get; set; }
        public int Tipo_uso { get; set; }
        public double Valor_mbtu { get; set; }
        public int Variable_id { get; set; }

    }

    
    public class ListaEmergentesNominacionsugeridaRes008
    {
        public ListaEmergentesNominacionsugeridaRes008()
        {
        }
        public string? Dia { get; set; }
        public int Cuenta_id { get; set; }
        public string? Cuenta { get; set; }
        public int Remitente_id { get; set; }
        public string? Remitente { get; set; }
        public int Reemplazante_id { get; set; }
        public string Reemplazante { get; set; }
        public int Fuente_id { get; set; }
        public string? Fuente { get; set; }
        public int Nodo_id { get; set; }
        public string? Nodo { get; set; }
        public int Contrato_id { get; set; }
        public string? Contrato { get; set; }
        public string? Tipo_uso_id { get; set; }
        public string? Tipo_uso { get; set; }
        public string? Mercado_id { get; set; }
        public string? Mercado { get; set; }
        public double Suge_nomi_linea { get; set; }
        public double Suge_nomi_posi_linea { get; set; }
        public double Valor_mbtu { get; set; }
        public double Cc_mbtu_tramo { get; set; }
        public double Acum_total_tramo { get; set; }
        public double Nomi_normal_total { get; set; }
        public double Porc_cea_tramo { get; set; }
        public double Nomi_normal { get; set; }
        public double Nomi_posit { get; set; }
        public double Acumulado { get; set; }
        public double Exceso { get; set; }
        public double Cc { get; set; }
        public double Poder { get; set; }
        public double Total_cea_tramo { get; set; }
        public int Tramo_id { get; set; }
        public string? Tramo { get; set; }
        public int Conteo { get; set; }
        public string? Estado { get; set; }
        public int Cuantos { get; set; }
        public string? Tipo { get; set; }
        public double Poder_nomi { get; set; }
        public double Porc_litC { get; set; }
        public double MaxiAut_total { get; set; }
        public int CuantosNO { get; set; }
    }

    
    public class ListadoEmergentesNominacionSugeridaRes008
    {
        public ListadoEmergentesNominacionSugeridaRes008()
        {
        }
        public List<ListaEmergentesNominacionsugeridaRes008> data;
        public string? Message { get; set; }
        public string? Cuantos { get; set; }
        public string? CuantosNO { get; set; }
        public bool Success { get; set; }
    }



    
    public class ManejoEmergenteNominacionSugeridadRes008
    {
        public ManejoEmergenteNominacionSugeridadRes008()
        {

        }


        public string[] VectorFecha { get; set; }
        public int[] VectorRemitente { get; set; }
        public int[] VectorReemplazante { get; set; }
        public int[] VectorFuente { get; set; }
        public int[] VectorNodo { get; set; }
        public int[] VectorContrato { get; set; }
        public int[] VectorTipoUso { get; set; }
        public int[] VectorMercado { get; set; }
        public int[] VectorNominacionNormal { get; set; }
        public int[] VectorNominacionPositiva { get; set; }
        public int[] Gasoducto { get; set; }
        public string[] Usuario { get; set; }
        public string[] Comentario { get; set; }
        public string[] Accion { get; set; }

    }


    public class GrabaRechazoNominacionPositivoRes008
    {
        public GrabaRechazoNominacionPositivoRes008()
        {

        }


        public string[] VectorFecha { get; set; }
        public int[] VectorRemitente { get; set; }
        public int[] VectorReemplazante { get; set; }
        public int[] VectorNodo { get; set; }
        public int[] VectorFuente { get; set; }
        public int[] VectorContrato { get; set; }
        public int[] VectorValor { get; set; }
        public string[] VectorMercado { get; set; }
        public string[] VectorTipoUso { get; set; }
        public string[] Comentario { get; set; }
        public int[] Gasoducto { get; set; }
        public string[] Usuario { get; set; }

    }

    
    public class ListadoClientesProveedores
    {
        public ListadoClientesProveedores()
        {
        }
        public int Cliente_id { get; set; }
        public string? Razon_social { get; set; }
        public float Valor_mbtu { get; set; }
    }

    
    public class ListadoRemitentesProveedores
    {
        public ListadoRemitentesProveedores()
        {
        }
        public int Cliente_id { get; set; }
        public string? Razon_social { get; set; }
        public float Valor_mbtu { get; set; }
    }

    [Serializable]
    public class ListadoTramosAfectadosNominacionCapacidadContratada
    {
        public ListadoTramosAfectadosNominacionCapacidadContratada()
        {
        }
        public string? Pis { get; set; }
        public string? Tramo { get; set; }
        public int Orden { get; set; }
        public double Cc { get; set; }
        public double Cea { get; set; }
        public double Cc_resta { get; set; }
    }

    [Serializable]
    public class ReprocesarCtaBalanceRes008
    {
        public ReprocesarCtaBalanceRes008()
        {

        }

        public string[] Fecha { get; set; }
        public List<int> Nodo { get; set; }
        public string[] Usuario { get; set; }
    }

    
    public class AsignacionAutomaticaRes008
    {
        public AsignacionAutomaticaRes008()
        {

        }

        public string[] Fecha { get; set; }
        public int[] GasoductoId { get; set; }
        public string[] Usuario { get; set; }
        public int[] Remitente { get; set; }
        public string[] Accion { get; set; }
    }

    
    public class ComentarioAsignacionGrabarAsignacionAutomatica
    {
        public ComentarioAsignacionGrabarAsignacionAutomatica()
        {

        }
        public string? Comentario { get; set; }
    }

    [Serializable]
    public class AcualizarBloqueAutorizacionGlobal
    {
        public AcualizarBloqueAutorizacionGlobal()
        {

        }

        public string[] Fecha { get; set; }
        public int[] Conteo { get; set; }
        public string[] Usuario { get; set; }
    }

    
    public class ComentarioGrabarAutorizacionGlobal
    {
        public ComentarioGrabarAutorizacionGlobal()
        {

        }
        public string? Comentario { get; set; }
    }

    
    public class InfoAutorizacion
    {
        public InfoAutorizacion()
        {
        }

        public int NominacionId { get; set; }
        public string? Estado { get; set; }
        public double ValorMbtu { get; set; }
        public string? Usuario { get; set; }
        public int Conteo { get; set; }
    }
    
    public class AutorizacionNominacionProveedores
    {
        public AutorizacionNominacionProveedores()
        {
        }

        public int NominacionTransporteId { get; set; }
        public int ClienteId { get; set; }
        public double ValorMbtu { get; set; }
        public string? Estado { get; set; }
        public string? Usuario { get; set; }
        public int ConteUo { get; set; }
    }

    [Serializable]
    public class DatosLlenarTablasTemporalesAutorizacion
    {
        public DatosLlenarTablasTemporalesAutorizacion()
        {
        }
        public string[] Usuario { get; set; }
        public InfoAutorizacion[] Modificados { get; set; }
        public List<List<ListaNominacionHoraria>> PerfilHorario { get; set; }
        public AutorizacionNominacionProveedores[] Proveedores { get; set; }

    }

    
    public class ComentarioActualizarTemporalesAutorizacion
    {
        public ComentarioActualizarTemporalesAutorizacion()
        {
        }
        string? ComentarioActualizarTablasAutorizacion { get; set; }
    }
}
