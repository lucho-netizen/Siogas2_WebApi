using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Siogas2_webapi.Models;

namespace Siogas2.Data.Parametrizacion
{
    internal class GasoductoRepository : RepositoryBase, IGasoductoRepository
    {
        private string? connectionString;

        public GasoductoRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public GasoductoRepository(string connectionString) : base(null)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<Gasoducto> TraerGasoductos(string opcion, string user_name)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string storedProcedureName = opcion == "MOVIL" ? "gen.Gasoducto_RetrieveByOptionUser" : "OtroStoredProcedure";

                var parameters = new DynamicParameters();
                parameters.Add("@opcion", opcion);
                parameters.Add("@userName", user_name);

                return connection.Query<Gasoducto>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }

    internal interface IGasoductoRepository
    {
        IEnumerable<Gasoducto> TraerGasoductos(string opcion, string user_name);
    }
}
