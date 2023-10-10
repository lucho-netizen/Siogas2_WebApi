
using Siogas2.Models.Nominacion;
using Siogas2.Models;
using Siogas2.Models.Parametrizacion;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;


namespace Siogas2.LogicInterfaces.Nominacion
{
    public interface IAutorizacionManager
    {
        EstadoNominacionTr Get(int Id);
        IEnumerable<EstadoNominacionTr> GetAll(int gasoId);
        void Remove(int Id);
        void Save(EstadoNominacionTr datos);
        IEnumerable<EstadoNominacionTr> EstadoNominacionTrGet(int filtro);
        IEnumerable<NominacionInfo> NominacionInfoGet(string dia,
                                           int cliente_id,
                                           int remitente_id,
                                           int nodo_id,
                                           int gasoducto_id,
                                           string tipo_nominacion,
                                           int campo_productor_id,
                                           int contrato_id,
                                           string estado,
                                           int variable_nominacion,
                                           int mercado_id,
                                           int tipo_uso_id,
                                           bool cero);
        /*ArrayList NominacionInfoGet(string dia, 
                                           int cliente_id,
                                           int remitente_id,
                                           int nodo_id,
                                           int gasoducto_id,
                                           string tipo_nominacion,
                                           int campo_productor_id,
                                           int contrato_id,
                                           string estado,
                                           int variable_nominacion,
                                           int mercado_id,
                                           int tipo_uso_id,
                                           bool cero);*/
        IEnumerable<Nodo> ClienteNodoGet(int cliente, int gasoductoId);
        IEnumerable<Campo_productor_lista> FuenteSuministrolistaGet(int gasoductoId);
        IEnumerable<ListaTrazabilidad> GetAllTrazabilidad(int gasoducto_Id, string dia_Nominado, int cliente_Id, int remitente_Id, int contrato_Id, int nodo_Id, int fuente_Suministro_Id, int tipo_Uso_Id, int mercado_Id);
        IEnumerable<ListaNominacionHoraria> NominacionHorariaGet(int idNominacion);
        IEnumerable<ListaNominacionDuplicada> NominacionDuplicadaGet(int gasoductoId, string fecha);
        IEnumerable<ListaDuplicadosEliminados> NominacionDuplicadaEliminadaGet(int gasoductoId, string fecha);
        void EliminarDuplicados(List<int> listaNominaciones, List<string> comentario, List<string> usuario);
        void RevertirEliminarDuplicados(List<int> listaNominaciones, List<string> comentario, List<string> usuario);
        IEnumerable<Lista_NominacionPs008> NominacionPs008Get(int gasoductoId, string fecha, string remitente);
        void EliminarAsignacion(List<string> dia, List<int> nodo, List<int> remitente, List<int> contrato, List<int> reemplazante, List<int> fuente_suministro, List<int> mercado, List<int> tipo_uso, List<int> valor_mbtu, List<int> variable_id);
        IEnumerable<FuentesAsignacion> FuenteAsignacion008Get(int nominacion, int gasoductoId);
        IEnumerable<ComentarioAsignacion> ComentarioAsignacion008Get(int nominacion, int gasoductoId);
        void GuardarAsignacion(NominacionAsignacion[] nominacion, FuentesAsignacion[] reparticion);
        IEnumerable<ListaEmergentesNominacionsugeridaRes008> ListaEmergenteNominacionSugerida008(string fecha, int gasoductoId, int clienteId, int remitenteId);
        void ManejoEmergenteNominacionSugeridaRes008(string[] vectorFecha, int[] vectorRemitente, int[] vectorReemplazante, int[] vectorFuente, int[] vectorNodo, int[] vectorContrato, int[] vectorTipoUso, int[] vectorMercado, int[] vectorNominacionNormal, int[] vectorNominacionPositiva, int[] gasoducto, string[] usuario, string[] comentario, string[] accion);
        void GrabarRechazoNominacionPositivo(string[] vectorFecha, int[] vectorRemitente, int[] vectorReemplazante, int[] vectorNodo, int[] vectorFuente, int[] vectorContrato, int[] vectorValor, string[] vectorMercado, string[] vectorTipoUso, string[] comentario, int[] gasoducto, string[] usuario);
        IEnumerable<ListadoClientesProveedores> ListadoClientesProvedores(int gasoductoId);
        IEnumerable<ListadoRemitentesProveedores> ListadoRemitentesProveedores(int idNominacion);
        IEnumerable<ListadoTramosAfectadosNominacionCapacidadContratada> ListadoTramosAfectadosCapacidadContratada(int nodoId, int fuenteId, int contratoId, string fecha, float valorCambiado, int fuenteEntrega, int cliente, int remitente, int tipoUsoId, int mercadoId);
        void ReprocesarCtaBalanceRes008(List<int> nodo, string[] fecha, string[] usuario);
        void ProcesarCuenta(List<int> nodo, string[] fecha, string[] usuario);
        IEnumerable<ComentarioAsignacionGrabarAsignacionAutomatica> GrabarAsignacionAutomaticaNominacionPuntoServicioRes008(string[] fecha, int[] remitente, string[] usuario, int[] gasoductoId, string[] accion);
        IEnumerable<ComentarioGrabarAutorizacionGlobal> ActualizarBloqueAutorizacionGlobal(string[] fecha, string[] usuario, int[] conteo);
        void ActualizarTemporalesAutorizacion(DataTable datatableModificados, DataTable datatableProveedores, DataTable datatablePerfilHorario);

    }
}
