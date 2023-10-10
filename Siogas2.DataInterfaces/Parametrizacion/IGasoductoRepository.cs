
using Siogas2.DataInterfaces;
using System.Collections.Generic;
using Models;

namespace Siogas2.DataInterfaces.Parametrizacion
{
    public interface IGasoductoRepository : IRepository<Gasoducto, int>
    {
        IEnumerable<GasoductoOptionUser> RetrieveByOptionUser(string opcion, string userName);
    }
}

