using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Integrated_Project.Data_Access
{
    public static class Input_and_Output
    {
        public static void  Input(string QueryString)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sql_Database")))
            {
                throw new NotImplementedException();
            }  
        }

        public static dynamic Output(string QueryString)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sql_Database")))
            {
                dynamic output = connection.Query<dynamic>(QueryString).ToList();
                return output;
            }
        }
    }
}