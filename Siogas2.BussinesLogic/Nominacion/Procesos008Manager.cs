using Microsoft.AspNetCore.Http;
using Siogas2.LogicInterfaces.Nominacion;
using Siogas2.Models.Nominacion;
using Siogas2.Models.Parametrizacion;
using Siogas2.DataInterfaces;
using Siogas2.DataInterfaces.Nominacion;

using System;
using System.Collections.Generic;

namespace Siogas2.BusinessLogic.Nominacion
{
    public class Procesos008Manager : IProcesos008Manager, IDisposable
    {
        private readonly IDataUnitOfWork dataUnitOfWork;
        private readonly IHttpContextAccessor processContext;

        public Procesos008Manager(IDataUnitOfWork dataUnitOfWork, IHttpContextAccessor processContext)
        {
            this.dataUnitOfWork = dataUnitOfWork;
            this.processContext = processContext;

        }

        public void Dispose()
        {
            this.dataUnitOfWork.Dispose();
        }

        public ListadoRecorte008 Get(int Procesos008Id)
        {
            return this.dataUnitOfWork.Procesos008Repository.Retrieve(Procesos008Id);
        }

        public IEnumerable<ListadoRecorte008> GetAll(string fecha, int gaso, int cta)
        {
            return this.dataUnitOfWork.Procesos008Repository.RetrieveAll(fecha, gaso, cta);
        }

        public IEnumerable<Cuenta_res_008> GetCuenta_res_008(string fecha, int gaso, int cta)
        {
            return this.dataUnitOfWork.Procesos008Repository.RetrieveCuenta_res_008(fecha, gaso, cta);
        }

        public void Remove(int Procesos008Id)
        {
            try
            {
                var dato = this.dataUnitOfWork.Procesos008Repository.Retrieve(Procesos008Id);

                this.dataUnitOfWork.Procesos008Repository.Delete(dato);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void Cut(List<Parametros008> datos)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.Cut(datos);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void NoCut(List<Parametros008> datos)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.NoCut(datos);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void Reverse(List<Parametros008> datos)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.Reverse(datos);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void Reset(List<Cuenta_res_008> datos)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.Reset(datos);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception e)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void Reprocess(Parametros008 dato)
        {
            if (dato == null) throw new ArgumentNullException(nameof(dato));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.Reprocess(dato);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void Bag(List<Parametros008> datos)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.Bag(datos);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void Cuts(List<Parametros008> datos)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.Cuts(datos);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void Emails(List<Parametros008> datos)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.Emails(datos);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void Report(List<Parametros008> datos)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.Report(datos);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }
        public IEnumerable<Cliente> GetCustomers(int id)
        {
            return this.dataUnitOfWork.Procesos008Repository.ClienteRetrieveComplete(id);
        }
        public IEnumerable<ListaCtas008> GetListaCtas(int gaso, int cliente)
        {
            return this.dataUnitOfWork.Procesos008Repository.ListaCuentas(gaso, cliente);
        }

        public IEnumerable<ListadoRecorte008> GetAll(int gasoId)
        {
            throw new NotImplementedException();
        }

        public void Save(ListadoRecorte008 datos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Nodos_res_008> GetListaNodos(int gaso, int cliente)
        {
            return this.dataUnitOfWork.Procesos008Repository.GetListaNodos(gaso, cliente);
        }

        public IEnumerable<Pis_res_008> GetListaPis(int gaso)
        {
            return this.dataUnitOfWork.Procesos008Repository.GetListaPis(gaso);
        }
        public IEnumerable<Bolsa_editar_res_008> GetBolsaEditar(string fecha, int gaso, int cliente)
        {
            return this.dataUnitOfWork.Procesos008Repository.GetBolsaEditAll(fecha, gaso, cliente);
        }

        public string AgregarBolsa(Parametros008 dato)
        {
            string sResultado = "";
            if (dato == null) throw new ArgumentNullException(nameof(dato));

            try
            {

                sResultado = this.dataUnitOfWork.Procesos008Repository.AgregarBolsa(dato);

                this.dataUnitOfWork.Commit();

                return sResultado;
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void RecAcu(List<Listado_recortes_editar> datos, string Usuario, string sFecha)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {

                this.dataUnitOfWork.Procesos008Repository.RecAcu(datos, Usuario, sFecha);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public IEnumerable<Listado_recortes_editar> GetListadoRecortesEditar(string fecha, int gaso, int cliente)
        {
            return this.dataUnitOfWork.Procesos008Repository.GetListadoRecortesEdit(fecha, gaso, cliente);
        }

        public Listado_control_activa_informe_res008 ActivaInforme(Parametros008 dato)
        {
            if (dato == null) throw new ArgumentNullException(nameof(dato));

            return this.dataUnitOfWork.Procesos008Repository.ActivReport(dato);

        }
    }
}
