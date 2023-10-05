using Microsoft.AspNetCore.Http;
using Siogas2.DataInterfaces;
using Models;
using System;
using System.Collections.Generic;
//using Siogas2.LogicInterfaces.Parametrizacion;


namespace Siogas2.BussinesLogic
{
    public class GasoductoManager : IGasoductoManager, IDisposable
    {
        private readonly IDataUnitOfWork dataUnitOfWork;
        private readonly IHttpContextAccessor processContext;

        public GasoductoManager(IDataUnitOfWork dataUnitOfWork, IHttpContextAccessor processContext)
        {
            this.dataUnitOfWork = dataUnitOfWork;
            this.processContext = processContext;
        }

        public void Dispose()
        {
            this.dataUnitOfWork.Dispose();
        }

        public Gasoducto Get(int gasoductoId)
        {
            return this.dataUnitOfWork.GasoductoRepository.Retrieve(gasoductoId);
        }

        public IEnumerable<Gasoducto> GetAll()
        {
            return this.dataUnitOfWork.GasoductoRepository.RetrieveAll();
        }

        public IEnumerable<GasoductoOptionUser> GetByOptionUser(string opcion, string userName)
        {
            return this.dataUnitOfWork.GasoductoRepository.RetrieveByOptionUser(opcion, userName);
        }

        public void Remove(int gasoductoId)
        {
            try
            {
                var dato = this.dataUnitOfWork.GasoductoRepository.Retrieve(gasoductoId);

                this.dataUnitOfWork.GasoductoRepository.Delete(dato);

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }
        }

        public void Save(Gasoducto datos)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));

            try
            {
                if (datos.gasoducto_id == 0)
                {
                    this.dataUnitOfWork.GasoductoRepository.Create(datos);
                }
                else
                {
                    this.dataUnitOfWork.GasoductoRepository.Update(datos);
                }

                this.dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                this.dataUnitOfWork.Dispose();

                throw;
            }


        }
    }
}
