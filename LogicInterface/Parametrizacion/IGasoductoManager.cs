using Models;
using System;
using System.Collections.Generic;

namespace Siogas2.LogicInterfaces.Parametrizacion
{
    public interface IGasoductoManager
    {
        Gasoducto Get(int gasoductoId);
        IEnumerable<Gasoducto> GetAll();
        IEnumerable<GasoductoOptionUser> GetByOptionUser(string opcion, string userName);
        void Remove(int gasoductoId);
        void Save(Gasoducto datos);
    }
}
