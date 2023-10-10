using Dapper;
using Siogas2.Data;
using Siogas2.DataInterfaces.Parametrizacion;
using Siogas2.Models.Parametrizacion;
using System;
using System.Collections.Generic;
using System.Data;

namespace Siogas2.Data.Parametrizacion
{
    internal class ClienteReventaRepository : RepositoryBase, IClienteReventaRepository
    {
        public ClienteReventaRepository(IDbTransaction transaction) : base(transaction)
        {

        }

        public void Create(ClienteReventa entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ClienteReventa entity)
        {
            throw new NotImplementedException();
        }

        public ClienteReventa Retrieve(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteReventa> RetrieveAll(int cliente_id, int gasoducto_id)
        {
            return Connection.Query<ClienteReventa>(
                "gen.ClienteReventa_RetrieveAll",
                param: new { cliente_id, gasoducto_id },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }

        public IEnumerable<ClienteReventa> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteReventa entity)
        {
            throw new NotImplementedException();
        }
    }
}
