using Siogas2_webapi.Models;
using Siogas3.DataInterfaces;
using System.Collections.Generic;

namespace Siogas2.DataInterfaces.Parametrizacion
{
    public interface IGasoductoRepository : IRepository<Gasoducto, int>
    {
        IEnumerable<GasoductoOptionUser> RetrieveByOptionUser(string opcion, string userName);
    }
}
