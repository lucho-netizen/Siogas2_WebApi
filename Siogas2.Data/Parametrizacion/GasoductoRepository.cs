using Dapper;
using Models;
using Siogas2.Data;
using Siogas2.DataInterfaces.Parametrizacion;
using Siogas2.Data.Utilities;
using Siogas2.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Siogas2.Data.Parametrizacion
{
    internal class GasoductoRepository : RepositoryBase, IGasoductoRepository
    {
        public GasoductoRepository(IDbTransaction transaction) : base(transaction)
        {

        }

        public void Create(Gasoducto entity)
        {
            string[] excludedProperties = new string[] { "gasoducto_id", "pais_extremo_inicial", "departamento_extremo_inicial", "municipio_extremo_inicial", "pais_extremo_final", "departamento_extremo_final", "municipio_extremo_final" };

            Connection.Execute(
                "gen.Gasoducto_Create",
                entity.GetDynamicParameters(excludedProperties: excludedProperties),
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }

        public void Delete(int id)
        {
            Connection.Execute(
                "gen.Gasoducto_Delete",
                param: new { id },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }

        public void Delete(Gasoducto entity)
        {
            Delete(entity.gasoducto_id);
        }

        public Gasoducto Retrieve(int id)
        {
            return Connection.Query<Gasoducto>(
                "gen.Gasoducto_RetrieveById",
                param: new { id },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                ).SingleOrDefault();
        }

        public IEnumerable<Gasoducto> RetrieveAll()
        {
            return Connection.Query<Gasoducto>(
                "gen.Gasoducto_RetrieveAll",
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }

        public IEnumerable<GasoductoOptionUser> RetrieveByOptionUser(string opcion, string userName)
        {
            return Connection.Query<GasoductoOptionUser>(
                "gen.Gasoducto_RetrieveByOptionUser",
                param: new { opcion = opcion, userName = userName },
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }

        public void Update(Gasoducto entity)
        {
            string[] excludedProperties = new string[] { "pais_extremo_inicial", "departamento_extremo_inicial", "municipio_extremo_inicial", "pais_extremo_final", "departamento_extremo_final", "municipio_extremo_final" };

            Connection.Execute(
                "gen.Gasoducto_Update",
                entity.GetDynamicParameters(excludedProperties: excludedProperties),
                transaction: Transaction,
                commandType: CommandType.StoredProcedure
                );
        }
    }
}
