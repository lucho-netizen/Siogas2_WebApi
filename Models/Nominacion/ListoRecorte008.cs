using System;
using System.Collections.Generic;

namespace Siogas2.Models.Nominacion
{
    
    public class ListadoRecorte008
    {
        public ListadoRecorte008()
        {

        }

        public int Nodo_linea_res_008_id { get; set; }
        public int Nnodo_linea_cuenta_id { get; set; }
        public int Cuenta_id { get; set; }
        public int Cliente_id { get; set; }
        public string? cliente { get; set; }
        public int Remitente_id { get; set; }
        public int Reemplazante_id { get; set; }
        public int Nodo_id { get; set; }
        public string? Nodo { get; set; }
        public int Fuente_id { get; set; }
        public string? Fuente { get; set; }
        public string? Dia { get; set; }
        public string? Cea { get; set; }
        public string? Ceap { get; set; }
        public string? Concepto { get; set; }
        public string? Acumulado { get; set; }
        public int Tramo_id { get; set; }
        public string? Tramo { get; set; }
        public float Contrato_id { get; set; }
        public string? Contrato { get; set; }
        public string? Cc { get; set; }
        public string? Poder_nomi { get; set; }
        public string? Poder_final { get; set; }
        public float ttotal_cea_tramo { get; set; }
        public float Cc_mbtu_linea { get; set; }
        public float Cc_mbtu_tramo { get; set; }
        public string Porc_5 { get; set; }
        public float Porcentaje { get; set; }
        public float Acum_total_tramo { get; set; }
        public float Exceso { get; set; }
        public float Acum_posi_linea { get; set; }
        public float Acum_posi_tramo { get; set; }
        public float Porc_acum_linea { get; set; }
        public string Usuario_cc_energia { get; set; }
        public string Fecha_hora_cc_energia { get; set; }
        public float onteo { get; set; }
        public float Recorte_tramo { get; set; }
        public float Recorte_linea { get; set; }
        public float Nuevo_acumulado { get; set; }
        public string? Usuario_conteo { get; set; }
        public string? Fecha_hora_conteo { get; set; }
        public string? Estado_recorte { get; set; }
        public string? Usuario_recorte { get; set; }
        public string? Fecha_hora_recorte { get; set; }
        public string? Comentario_recorte { get; set; }
        public string? Estado_recorte_id { get; set; }

    }

    
    public class ListaCtas008
    {
        public ListaCtas008()
        {

        }

        public int Admon_cuenta_balance_id { get; set; }
        public string? Nombre { get; set; }

    }

    
    public class Parametros008
    {
        public Parametros008()
        {

        }

        public string? fecha { get; set; }
        public string? fecha2 { get; set; }
        public string? usuario { get; set; }
        public string? gasoducto { get; set; }
        public string? cliente { get; set; }
        public string? comentario { get; set; }
        public int recorte { get; set; }
        public int cta { get; set; }
        public int remitente { get; set; }
        public int remplazante { get; set; }
        public int pis { get; set; }
        public int nodo { get; set; }
        public int acumulado { get; set; }
        public int Tramo { get; set; }
        public string accion { get; set; }
    }

    
    public class Cuenta_res_008
    {
        public Cuenta_res_008()
        {

        }
        public int remitente_id { get; set; }
        public string remitente { get; set; }
        public string dia { get; set; }
        public int tramo_id { get; set; }
        public string tramo { get; set; }
        public string conteo { get; set; }
        public string comentario { get; set; }
        public string usuario { get; set; }
    }

    [Serializable]
    public class Pis_res_008
    {
        public Pis_res_008()
        {

        }
        public int pis_id { get; set; }
        public string? Pis { get; set; }
    }

    
    public class Nodos_res_008
    {
        public Nodos_res_008()
        {

        }
        public int nodo_id { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public int tramo_id { get; set; }
    }

    
    public class Bolsa_editar_res_008
    {
        public Bolsa_editar_res_008()
        {

        }
        public int bolsa_res_008_id { get; set; }
        public string cliente { get; set; }
        public string reemplazante { get; set; }
        public int cliente_id { get; set; }
        public int reemplazante_id { get; set; }
        public int pis_id { get; set; }
        public string pis { get; set; }
        public string nodo { get; set; }
        public int nodo_id { get; set; }
        public string comentario { get; set; }
        public int valor_bolsa { get; set; }
        public int acumulado_bolsa { get; set; }
        public int acumulado_antes { get; set; }
        public string fecha { get; set; }
        public int tramo_id { get; set; }
        public string tramo { get; set; }
        public string comentario_libera { get; set; }
    }

    
    public class Listado_recortes_editar
    {
        public Listado_recortes_editar()
        {

        }
        public int bolsa_res_008_id { get; set; }
        public string cliente { get; set; }
        public string reemplazante { get; set; }
        public int cliente_id { get; set; }
        public int reemplazante_id { get; set; }
        public int pis_id { get; set; }
        public string pis { get; set; }
        public string nodo { get; set; }
        public int nodo_id { get; set; }
        public string comentario_recorte { get; set; }
        public int recorte_linea { get; set; }
        public int recorte_acumulado { get; set; }
        public string fecha { get; set; }
        public int tramo_id { get; set; }
        public string tramo { get; set; }
        public string comentario_libera { get; set; }
        public int recorte_acumulado_original { get; set; }
    }

    
    public class InfoGrabaRecorteRes008
    {
        public InfoGrabaRecorteRes008()
        {

        }
        public List<Listado_recortes_editar> Datos { get; set; }
        public string? Usuario { get; set; }
        public string? Fecha { get; set; }
    }
    
    public class Tabla_control_activa_informe_res008
    {
        public int activa_informe_res008_id;
        public string? Fecha;
        public bool activado;
        public string? Fuente;
        public string? Fechahora;
        public string? Usuario;
        public string? Estado;
    }
    
    public class Listado_control_activa_informe_res008
    {
        public List<Tabla_control_activa_informe_res008> data;
        public string? message;
        public string? cuantos;
        public bool success;
    }
}
