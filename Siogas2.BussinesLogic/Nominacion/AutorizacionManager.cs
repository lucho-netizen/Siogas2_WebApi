using Microsoft.AspNetCore.Http;
using Siogas2.DataInterfaces;
using Siogas2.LogicInterfaces.Nominacion;
using Siogas2.Models.Nominacion;
using Siogas2.Models.Parametrizacion;
using Models;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;



namespace Siogas2.BusinessLogic.Nominacion
{
    public class AutorizacionManager : IAutorizacionManager, IDisposable
    {
        private readonly IDataUnitOfWork dataUnitOfWork;
        private readonly IHttpContextAccessor processContext;


        public AutorizacionManager(IDataUnitOfWork dataUnitOfWork, IHttpContextAccessor processContext)
        {
            this.dataUnitOfWork = dataUnitOfWork;
            this.processContext = processContext;
        }

        public void Dispose()
        {
            this.dataUnitOfWork.Dispose();
        }
        public EstadoNominacionTr Get(int ConfirmacionAutorizacionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EstadoNominacionTr> GetAll(int gasoId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int ConfirmacionAutorizacionId)
        {
            throw new NotImplementedException();
        }

        public void Save(EstadoNominacionTr datos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EstadoNominacionTr> EstadoNominacionTrGet(int filtro)
        {
            return this.dataUnitOfWork.AutorizacionRepository.EstadoNominacionTrRetrieve(filtro);
        }

        public IEnumerable<NominacionInfo> NominacionInfoGet(string dia,
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
                                             bool cero)
        {
            int valorCero = (cero) ? 1 : 0;
            return this.dataUnitOfWork.AutorizacionRepository.NominacionInfoRetrieve(dia, cliente_id, remitente_id, nodo_id, gasoducto_id, tipo_nominacion, campo_productor_id, contrato_id, estado, variable_nominacion, mercado_id, tipo_uso_id, valorCero);
        }
        /*public ArrayList NominacionInfoGet(string dia, 
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
                                             bool cero)
        {
            int valorCero = (cero) ? 1 : 0;
            return this.dataUnitOfWork.AutorizacionRepository.NominacionInfoRetrieve( dia,  cliente_id, remitente_id, nodo_id, gasoducto_id, tipo_nominacion, campo_productor_id, contrato_id, estado, variable_nominacion, mercado_id, tipo_uso_id, valorCero);
        }*/
        public IEnumerable<Nodo> ClienteNodoGet(int cliente, int gasoductoId)
        {
            return this.dataUnitOfWork.AutorizacionRepository.ClienteNodoRetrieve(cliente, gasoductoId);
        }
        public IEnumerable<Campo_productor_lista> FuenteSuministrolistaGet(int gasoductoId)
        {
            return this.dataUnitOfWork.AutorizacionRepository.FuenteSuministrolistaRetrieve(gasoductoId);
        }

        public IEnumerable<ListaTrazabilidad> GetAllTrazabilidad(int gasoducto_Id, string dia_Nominado, int cliente_Id, int remitente_Id, int contrato_Id, int nodo_Id, int fuente_Suministro_Id, int tipo_Uso_Id, int mercado_Id)
        {
            return this.dataUnitOfWork.AutorizacionRepository.trazabilidadRetrieve(gasoducto_Id, dia_Nominado, cliente_Id, remitente_Id, contrato_Id, nodo_Id, fuente_Suministro_Id, tipo_Uso_Id, mercado_Id);
        }

        public IEnumerable<ListaNominacionHoraria> NominacionHorariaGet(int idNominacion)
        {
            return this.dataUnitOfWork.AutorizacionRepository.NominacionHorariaRetrieve(idNominacion);
        }

        public IEnumerable<ListaNominacionDuplicada> NominacionDuplicadaGet(int gasoducto_Id, string fecha)
        {
            return this.dataUnitOfWork.AutorizacionRepository.nominacionDuplicadaRetrieve(gasoducto_Id, fecha);
        }
        public IEnumerable<ListaDuplicadosEliminados> NominacionDuplicadaEliminadaGet(int gasoducto_Id, string fecha)
        {
            return this.dataUnitOfWork.AutorizacionRepository.nominacionDuplicadaEliminadaRetrieve(gasoducto_Id, fecha);
        }

        public void EliminarDuplicados(List<int> lista, List<string> cometario, List<string> usuario)
        {
            try
            {

                for (int iRecorreNominaciones = 0; iRecorreNominaciones < lista.Count; iRecorreNominaciones++)
                {

                    this.dataUnitOfWork.AutorizacionRepository.EliminarDuplicados(lista[iRecorreNominaciones], cometario[iRecorreNominaciones], usuario[iRecorreNominaciones]);


                }


                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void revertirEliminarDuplicados(List<int> lista, List<string> cometario, List<string> usuario)
        {
            try
            {

                for (int iRecorreNominaciones = 0; iRecorreNominaciones < lista.Count; iRecorreNominaciones++)
                {

                    this.dataUnitOfWork.AutorizacionRepository.evertirEliminarDuplicados(lista[iRecorreNominaciones], cometario[iRecorreNominaciones], usuario[iRecorreNominaciones]);


                }


                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }


        public IEnumerable<Lista_NominacionPs008> NominacionPs008Get(int gasoducto_Id, string fecha, string remitente)
        {
            return this.dataUnitOfWork.AutorizacionRepository.nominacionPs008Retrieve(gasoducto_Id, fecha, remitente);
        }



        public void EliminarAsignacion(List<string> dia, List<int> nodo, List<int> remitente, List<int> contrato, List<int> reemplazante, List<int> fuente_suministro, List<int> mercado, List<int> tipo_uso, List<int> valor_mbtu, List<int> variable_id)
        {

            try
            {
                for (int iRecorreNominacion = 0; iRecorreNominacion < nodo.Count; iRecorreNominacion++)
                {

                    this.dataUnitOfWork.AutorizacionRepository.EliminarAsignacion(dia[iRecorreNominacion], nodo[iRecorreNominacion], remitente[iRecorreNominacion], contrato[iRecorreNominacion], reemplazante[iRecorreNominacion], fuente_suministro[iRecorreNominacion], mercado[iRecorreNominacion], tipo_uso[iRecorreNominacion], valor_mbtu[iRecorreNominacion], variable_id[iRecorreNominacion]);


                }

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }


        public IEnumerable<FuentesAsignacion> FuenteAsignacion008Get(int nominacion, int gasoducto_Id)
        {
            return this.dataUnitOfWork.AutorizacionRepository.FuenteAsignacion008Retrieve(nominacion, gasoducto_Id);
        }

        public IEnumerable<ComentarioAsignacion> ComentarioAsignacion008Get(int nominacion, int gasoducto_Id)
        {
            return this.dataUnitOfWork.AutorizacionRepository.ComentarioAsignacion008Retrieve(nominacion, gasoducto_Id);
        }


        public void GuardarAsignacion(NominacionAsignacion[] nominacion, FuentesAsignacion[] reparticion)
        {
            try
            {
                this.dataUnitOfWork.AutorizacionRepository.GuardarAsignacion(nominacion, reparticion);


                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();
                throw;
            }
        }

        public IEnumerable<ListaEmergentesNominacionsugeridaRes008> ListaEmergenteNominacionSugerida008(string fecha, int gasoductoId, int clienteId, int remitenteId)
        {
            return this.dataUnitOfWork.AutorizacionRepository.ListaEmergenteNominacionSugeridaa008Retrieve(fecha, gasoductoId, clienteId, remitenteId);
        }

        public void ManejoEmergenteNominacionSugeridaRes008(string[] vectorFecha, int[] vectorRemitente, int[] vectorReemplazante, int[] vectorFuente, int[] vectorNodo, int[] vectorContrato, int[] vectorTipoUso, int[] vectorMercado, int[] vectorNominacionNormal, int[] vectorNominacionPositiva, int[] gasoducto, string[] usuario, string[] comentario, string[] accion)
        {
            try
            {
                this.dataUnitOfWork.AutorizacionRepository.manejoEmergenteNominacionSugeridaRes008(vectorFecha, vectorRemitente, vectorReemplazante, vectorFuente, vectorNodo, vectorContrato, vectorTipoUso, vectorMercado, vectorNominacionNormal, vectorNominacionPositiva, gasoducto, usuario, comentario, accion);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }

        }


        public void GrabarRechazoNominacionPositivo(string[] vectorFecha, int[] vectorRemitente, int[] vectorReemplazante, int[] vectorNodo, int[] vectorFuente, int[] vectorContrato, int[] vectorValor, string[] vectorMercado, string[] vectorTipoUso, string[] comentario, int[] gasoducto, string[] usuario)
        {
            try
            {
                this.dataUnitOfWork.AutorizacionRepository.grabarRechazoNominacionPositivo(vectorFecha, vectorRemitente, vectorReemplazante, vectorNodo, vectorFuente, vectorContrato, vectorValor, vectorMercado, vectorTipoUso, comentario, gasoducto, usuario);


                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }

        }

        public IEnumerable<ListadoClientesProveedores> ListadoClientesProvedores(int gasoducto_Id)
        {
            return this.dataUnitOfWork.AutorizacionRepository.listadoClientesProveedoresRetrieve(gasoducto_Id);
        }

        public IEnumerable<ListadoRemitentesProveedores> listadoRemitentesProveedores(int idNominacion)
        {
            return this.dataUnitOfWork.AutorizacionRepository.listadoRemitentesProveedores(idNominacion);
        }

        public IEnumerable<ListadoTramosAfectadosNominacionCapacidadContratada> listadoTramosAfectadosCapacidadContratada(int nodoId, int fuenteId, int contratoId, string fecha, float valorCambiado, int fuenteEntrega, int cliente, int remitente, int tipoUsoId, int mercadoId)
        {
            return this.dataUnitOfWork.AutorizacionRepository.listadoTramosAfectadosCapacidadContratada(nodoId, fuenteId, contratoId, fecha, valorCambiado, fuenteEntrega, cliente, remitente, tipoUsoId, mercadoId);
        }

        public void ReprocesarCtaBalanceRes008(List<int> nodo, string[] fecha, string[] usuario)
        {
            try
            {
                this.dataUnitOfWork.AutorizacionRepository.reprocesarCtaBalanceRes008(nodo, fecha, usuario);


                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }

        }

        public void ProcesarCuenta(List<int> nodo, string[] fecha, string[] usuario)
        {
            try
            {
                this.dataUnitOfWork.AutorizacionRepository.procesarCuenta(nodo, fecha, usuario);


                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }

        }

        public IEnumerable<ComentarioAsignacionGrabarAsignacionAutomatica> grabarAsignacionAutomaticaNominacionPuntoServicioRes008(string[] fecha, int[] remitente, string[] usuario, int[] gasoductoId, string[] accion)
        {

            return this.dataUnitOfWork.AutorizacionRepository.grabarAsignacionAutomaticaNominacionPuntoServicioRes008(fecha, remitente, usuario, gasoductoId, accion);
        }

        public IEnumerable<ComentarioGrabarAutorizacionGlobal> actualizarBloqueAutorizacionGlobal(string[] fecha, string[] usuario, int[] conteo)
        {

            return this.dataUnitOfWork.AutorizacionRepository.actualizarBloqueAutorizacionGlobal(fecha, usuario, conteo);

        }

        public void actualizarTemporalesAutorizacion(DataTable datatableModificados, DataTable datatableProveedores, DataTable datatablePerfilHorario)
        {
            this.actualizarTemporalesAutorizacion(datatableModificados, datatableProveedores, datatablePerfilHorario);
        }
    }
}
