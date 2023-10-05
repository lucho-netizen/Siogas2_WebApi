using Siogas2.Models.Parametrizacion;
using Siogas3.DataInterfaces;
using System.Collections.Generic;

namespace Siogas2.DataInterfaces.Parametrizacion
{
    public interface IClienteReventaRepository : IRepository<ClienteReventa,int>
    { 
     IEnumerable<ClienteReventa> RetrieveAll(int cliente_id, int gasoducto_id);
    }
}
