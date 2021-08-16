using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace InsertDataUsingDapper.Models
{
    public static class DapperORM
    {
        private static string connectionString = @"Data Source=DESKTOP-OOFHTK8\SQLEXPRESS;Initial Catalog=DapperKGE;Integrated Security=True";
        public static void ExecutedWithoutReturn(string procedureName, DynamicParameters param=null)
        {
            using(SqlConnection sqlcon=new SqlConnection(connectionString))
            {
                sqlcon.Open();
                sqlcon.Execute(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public static T ExecuteReturnScalar<T>(string procedureName,DynamicParameters param=null)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                return (T)Convert.ChangeType(sqlcon.ExecuteScalar(procedureName, param, commandType: System.Data.CommandType.StoredProcedure),typeof(T));
            }
        }

        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param=null)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                return sqlcon.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}