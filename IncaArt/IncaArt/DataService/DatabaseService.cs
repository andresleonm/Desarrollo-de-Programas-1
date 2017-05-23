using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Data;
namespace WindowsFormsApp1.DataService
{
    public class DatabaseService
    {
        string conn_string = "Server=dp1test.c4d2tgrzz55h.us-west-2.rds.amazonaws.com;Port=5432;Database=dp1db;User Id=dp1admin;Password=dp1admin;";
        public DataSet execute_function( string function,List<Parameter> parameters)
        {
            DataSet ds = new DataSet();

            var conn = new NpgsqlConnection(conn_string);
            conn.Open();
            var tran = conn.BeginTransaction();
            var cmd = new NpgsqlCommand(function, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (Parameter p in parameters)
            {
                cmd.Parameters.Add(new NpgsqlParameter(p.name, NpgsqlDbType.Text));
                cmd.Parameters[p.name].Value = p.value;
            }
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(ds);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0}", r[0]);
            }

            tran.Commit();
            conn.Close();
            return ds;
            
        }

        
    }
}
