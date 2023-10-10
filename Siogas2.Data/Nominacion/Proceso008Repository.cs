using Dapper;
using Siogas2.Data;
using Siogas2.DataInterfaces.Nominacion;
using Siogas2.Models.Nominacion;
using Siogas2.Models.Parametrizacion;
using Siogas2.Data.Utilities;
using Siogas2.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Siogas2.Data.Nominacion
{
    internal class Procesos008Repository : RepositoryBase, IProcesos008Repository
    {


        public Procesos008Repository(IDbTransaction transaction) : base(transaction)
        {

        }

        public ListadoRecorte008 Retrieve(int id)
        {
            return Connection.Query<ListadoRecorte008>(
                "gen.Procesos008_RetrieveById",
                param: new { id },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                ).SingleOrDefault();
        }

        public IEnumerable<ListadoRecorte008> RetrieveAll(string fecha, int gaso, int cta)
        {
            return Connection.Query<ListadoRecorte008>(
                "dbo.listado_recorte_008",
                param: new { Fecha = fecha, gasoducto = gaso, cuenta = cta },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }
        public IEnumerable<ListadoRecorte008> RetrieveAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cuenta_res_008> RetrieveCuenta_res_008(string dia, int gaso, int cta)
        {
            return Connection.Query<Cuenta_res_008>(
                "dbo.listado_recorte_008",
                param: new { fecha = dia, gasoducto = gaso, cuenta = cta },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }

        public void Cut(List<Parametros008> entity)
        {
            string[] excludedProperties = new string[] { "nodo_porcentaje_res008_id", "nombre", "fecha_hora" };
            foreach (Parametros008 item in entity)
            {
                Connection.Execute(
                "dbo.ejecutar_recortes_res_008",
                param: new { id_recorte = item.recorte, Usuario = item.usuario, comentario = "" },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

                Connection.Execute(
                "dbo.ejecutar_recorte_oba_mes_res_008",
                param: new { Fecha = item.fecha, Gasoducto = item.gasoducto, Usuario = item.usuario, tipo = "RECORTE" },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

                Connection.Execute(
                "dbo.ajuste_contador_recorte",
                param: new { fecha = item.fecha, usuario = item.usuario },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

            }

        }

        public void NoCut(List<Parametros008> entity)
        {

            foreach (Parametros008 item in entity)
            {
                Connection.Execute(
                "dbo.ejecutar_no_recortes_res_008",
                param: new { id_recorte = item.recorte, Usuario = item.usuario, Comentario = item.comentario },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

                Connection.Execute(
                "dbo.listado_recorte_008",
                param: new { Fecha = item.fecha, Gasoducto = item.gasoducto, cuenta = item.cta },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );


            }

        }

        public void Reverse(List<Parametros008> entity)
        {

            foreach (Parametros008 item in entity)
            {
                Connection.Execute(
                "dbo.ejecutar_no_recortes_res_008",
                param: new { id_recorte = item.recorte, Usuario = item.usuario, Comentario = item.comentario },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

                Connection.Execute(
                "dbo.listado_recorte_008",
                param: new { Fecha = item.fecha, Gasoducto = item.gasoducto, cuenta = item.cta },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );


            }

        }

        public void Reset(List<Cuenta_res_008> entity)
        {
            string Instruccion = "";

            foreach (Cuenta_res_008 item in entity)
            {
                Instruccion = " remitente_id = " + item.remitente_id.ToString() + " and tramo_id = " + item.tramo_id.ToString();

                Connection.Execute(
                "dbo.sp_reseteo_contador_res008",
                param: new { Instruccion = Instruccion, Comentario = item.comentario, Dia = item.dia, cliente = item.remitente_id, Usuario = item.usuario, tramo = item.tramo_id },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

            }

        }

        public void Reprocess(Parametros008 item)
        {

            Connection.Execute(
                 "dbo.calculo_cc_energia_tramo_filtros_res_008",
                 param: new { fecha1 = item.fecha, Fecha2 = item.fecha2, p_cliente = item.cliente, Usuario = item.usuario, Gasoducto = item.gasoducto },
                 transaction: Transaction,
                 commandType: CommandType.StoredProcedure
                 );

        }
        public string AgregarBolsa(Parametros008 item)
        {
            return Connection.Query<string>(
                "dbo.graba_new_bolsa_res_008",
                param: new
                {
                    Gasoducto_id = item.gasoducto,
                    Fecha = item.fecha,
                    remi_id = item.remitente,
                    reem_id = item.remitente,
                    pis_id = item.pis,
                    nodo_id = item.nodo,
                    tramo_id = item.Tramo,
                    valor_acum = item.acumulado,
                    Comentario = item.comentario,
                    Usuario = item.usuario,
                    Accion = item.accion
                },
                transaction: Transaction,
            commandType: CommandType.StoredProcedure
                ).SingleOrDefault();

        }
        public void RecAcu(List<Listado_recortes_editar> items, string Usuario, string sFecha)
        {

            System.Random random = new System.Random();
            int datoRandom = random.Next(1, 100000);

            Connection.Execute(
                     "dbo.borraRecorteRes008",
            transaction: Transaction,
                     commandType: CommandType.StoredProcedure
                     );

            foreach (Listado_recortes_editar item in items)
            {

                Connection.Execute(
                     "dbo.grabaRecorteRes008",
                     param: new { id = datoRandom, id_res_edi = item.bolsa_res_008_id, valor = item.recorte_acumulado, comentario = item.comentario_libera },
                     transaction: Transaction,
                     commandType: CommandType.StoredProcedure
                     );
            }

            Connection.Execute(
                     "dbo.graba_edicion_recorte_masivo_res_008",
                     param: new { id = datoRandom, usuario = Usuario, fecha = sFecha },
                     transaction: Transaction,
                     commandType: CommandType.StoredProcedure
                     );
        }
        public void Bag(List<Parametros008> entity)
        {

            foreach (Parametros008 item in entity)
            {
                Connection.Execute(
                "dbo.ejecutar_no_recortes_res_008",
                param: new { id_recorte = item.recorte, Usuario = item.usuario, Comentario = item.comentario },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

                Connection.Execute(
                "dbo.listado_recorte_008",
                param: new { Fecha = item.fecha, Gasoducto = item.gasoducto, cuenta = item.cta },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );


            }

        }

        public void Cuts(List<Parametros008> entity)
        {

            foreach (Parametros008 item in entity)
            {
                Connection.Execute(
                "dbo.ejecutar_no_recortes_res_008",
                param: new { id_recorte = item.recorte, Usuario = item.usuario, Comentario = item.comentario },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

                Connection.Execute(
                "dbo.listado_recorte_008",
                param: new { Fecha = item.fecha, Gasoducto = item.gasoducto, cuenta = item.cta },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );


            }

        }

        public void Emails(List<Parametros008> entity)
        {

            foreach (Parametros008 item in entity)
            {
                Connection.Execute(
                "dbo.ejecutar_no_recortes_res_008",
                param: new { id_recorte = item.recorte, Usuario = item.usuario, Comentario = item.comentario },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

                Connection.Execute(
                "dbo.listado_recorte_008",
                param: new { Fecha = item.fecha, Gasoducto = item.gasoducto, cuenta = item.cta },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );


            }

        }

        public void Report(List<Parametros008> entity)
        {

            foreach (Parametros008 item in entity)
            {
                Connection.Execute(
                "dbo.ejecutar_no_recortes_res_008",
                param: new { id_recorte = item.recorte, Usuario = item.usuario, Comentario = item.comentario },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );

                Connection.Execute(
                "dbo.listado_recorte_008",
                param: new { Fecha = item.fecha, Gasoducto = item.gasoducto, cuenta = item.cta },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );


            }

        }
        public void Create(ListadoRecorte008 entity)
        {
            throw new System.NotImplementedException();
        }
        public void Delete(int id)
        {
            Connection.Execute(
                "gen.Procesos008_Delete",
                param: new { id },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }

        public void Delete(ListadoRecorte008 entity)
        {
            Delete(entity.Nodo_linea_res_008_id);
        }

        public void Update(ListadoRecorte008 entity)
        {
            string[] excludedProperties = new string[] { "nombre", "fecha_hora" };
            Connection.Execute(
                "gen.Procesos008_Update",
                entity.GetDynamicParameters(excludedProperties: excludedProperties),
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }

        public IEnumerable<Cliente> ClienteRetrieveComplete(int id)
        {
            return Connection.Query<Cliente>(
                "gen.Cliente_RetrieveAll",
                param: new { id },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }

        public IEnumerable<ListaCtas008> ListaCuentas(int gasoId, int cliente)
        {
            return Connection.Query<ListaCtas008>(
                "gen.listado_recorte_008_ctas",
                param: new { gaso = gasoId, cliente_id = cliente },
            transaction: Transaction,
                commandType: CommandType.StoredProcedure
            );
        }

        public IEnumerable<Nodos_res_008> GetListaNodos(int gasoId, int cliente)
        {
            return Connection.Query<Nodos_res_008>(
                "gen.spListaNodos",
                param: new { gaso = gasoId, Cliente = cliente },
            transaction: Transaction,
                commandType: CommandType.StoredProcedure
            );
        }

        public IEnumerable<Pis_res_008> GetListaPis(int gasoId)
        {
            return Connection.Query<Pis_res_008>(
               "gen.sp_GetListaPis",
               param: new { gaso = gasoId },
            transaction: Transaction,
            commandType: CommandType.StoredProcedure
               );
        }
        public IEnumerable<Bolsa_editar_res_008> GetBolsaEditAll(string fecha, int gaso, int cliente)
        {
            return Connection.Query<Bolsa_editar_res_008>(
                "dbo.bolsa_editar",
                param: new { Fecha = fecha, gasoducto_id = gaso, cliente_id = cliente },
            transaction: Transaction,
            commandType: CommandType.StoredProcedure
                );
        }
        public IEnumerable<Listado_recortes_editar> GetListadoRecortesEdit(string fecha, int gaso, int cliente)
        {
            return Connection.Query<Listado_recortes_editar>(
                "dbo.listado_recortes_editar_res008",
                param: new { fecha = fecha, gasoducto_id = gaso, cliente_id = cliente },
                transaction: Transaction,
            commandType: CommandType.StoredProcedure
                );
        }

        public Listado_control_activa_informe_res008 ActivReport(Parametros008 dato)
        {
            IEnumerable<Tabla_control_activa_informe_res008> info;
            Listado_control_activa_informe_res008 resultado = new Listado_control_activa_informe_res008();
            List<Tabla_control_activa_informe_res008> datos = new List<Tabla_control_activa_informe_res008>();
            info = Connection.Query<Tabla_control_activa_informe_res008>(
                "dbo.control_activa_informe_res008",
                param: new
                {
                    Fecha = dato.fecha,
                    Usuario = dato.usuario,
                    Accion = dato.accion
                },
                transaction: Transaction,
            commandType: CommandType.StoredProcedure
                );
            foreach (Tabla_control_activa_informe_res008 item in info)
            {
                Tabla_control_activa_informe_res008 e = new Tabla_control_activa_informe_res008();

                e.activa_informe_res008_id = int.Parse(item.activa_informe_res008_id.ToString());
                e.Fecha = item.Fecha.ToString();
                e.activado = item.activado;
                e.Fuente = item.Fuente.ToString().Trim();
                e.Fechahora = item.Fechahora.ToString();
                e.Usuario = item.Usuario.ToString().Trim();
                e.Estado = item.Estado.ToString().Trim();

                datos.Add(e);
            }

            if (datos.Count > 0)
            {
                //datos.AddRange(lista_componentes);
                resultado.success = true;
                resultado.data = datos;
                resultado.message = "con datos";
                resultado.cuantos = datos.Count.ToString();
            }
            else
            {
                resultado.success = true;
                resultado.data = null;
                resultado.message = "sin datos";
                resultado.cuantos = datos.Count.ToString();
            }
            return resultado;
        }
    }
}

