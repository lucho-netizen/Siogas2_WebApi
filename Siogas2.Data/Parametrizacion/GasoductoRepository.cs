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

        

        public IEnumerable<GasoductoOptionUser> TraerGasoductos(string opcion, string user_name)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string storedProcedureName = opcion == "MOVIL" ? "gen.Gasoducto_RetrieveByOptionUser" : "OtroStoredProcedure";

                var parameters = new DynamicParameters();
                parameters.Add("@opcion", opcion);
                parameters.Add("@userName", user_name);

                return connection.Query<GasoductoOptionUser>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure, transaction: Transaction);
            }
        }
    }

    internal interface IGasoductoRepository
    {
        IEnumerable<GasoductoOptionUser> TraerGasoductos(string opcion, string user_name);
    }
}
