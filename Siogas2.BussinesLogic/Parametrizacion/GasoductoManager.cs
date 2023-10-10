using Microsoft.AspNetCore.Http;
using Siogas2.DataInterfaces;
using Models;
using System;
using Siogas2.LogicInterfaces;
using Siogas2.LogicInterfaces.Parametrizacion;
using Siogas2.Models;
using System.Collections.Generic;

namespace Siogas2.BussinesLogic.Parametrizacion
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
            dataUnitOfWork.Dispose();
        }

        public Gasoducto Get(int gasoductoId)
        {
            return dataUnitOfWork.GasoductoRepository.Retrieve(gasoductoId);
        }

        public IEnumerable<Gasoducto> GetAll()
        {
            return dataUnitOfWork.GasoductoRepository.RetrieveAll();
        }

        public IEnumerable<GasoductoOptionUser> GetByOptionUser(string opcion, string userName)
        {
            return dataUnitOfWork.GasoductoRepository.RetrieveByOptionUser(opcion, userName);
        }

        public void Remove(int gasoductoId)
        {
            try
            {
                var dato = dataUnitOfWork.GasoductoRepository.Retrieve(gasoductoId);

                dataUnitOfWork.GasoductoRepository.Delete(dato);

                dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                dataUnitOfWork.Dispose();

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
                    dataUnitOfWork.GasoductoRepository.Create(datos);
                }
                else
                {
                    dataUnitOfWork.GasoductoRepository.Update(datos);
                }

                dataUnitOfWork.Commit();
            }
            catch (Exception)
            {
                dataUnitOfWork.Dispose();

                throw;
            }
        }

    }
}
