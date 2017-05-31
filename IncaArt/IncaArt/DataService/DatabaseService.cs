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
        public string user;
        public string password;

        public DatabaseService(string user,string password)
        {
            this.user = user;
            this.password = password;
        }

        // deben usar execute_function cuando quieran retornar grillas de informacion
        protected GenericResult execute_function(string function, List<Parameter> parameters)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(conn_string);
                conn.Open();
                NpgsqlTransaction tran = conn.BeginTransaction();
                NpgsqlCommand cmd = new NpgsqlCommand(function, conn);
                foreach (Parameter p in parameters)
                {
                    cmd.Parameters.Add(new NpgsqlParameter(p.name, NpgsqlDbType.Text));
                    cmd.Parameters[p.name].Value = p.value;
                }
                cmd.CommandType = CommandType.StoredProcedure;
                var sql = new StringBuilder();
                using (var reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
                    while (reader.Read())
                        sql.AppendLine($"FETCH ALL IN \"{ reader.GetString(0) }\";");

                List<Row> result = new List<Row>();
                using (var cmd2 = new NpgsqlCommand())
                {
                    cmd2.Connection = cmd.Connection;
                    cmd2.Transaction = cmd.Transaction;
                    cmd2.CommandTimeout = cmd.CommandTimeout;
                    cmd2.CommandText = sql.ToString();
                    cmd2.CommandType = CommandType.Text;
                    NpgsqlDataReader dr = cmd2.ExecuteReader();


                    while (dr.Read())
                    {
                        List<string> cols = new List<string>();
                        int ncols = dr.FieldCount;
                        for (int i = 0; i < ncols; i++)
                        {
                            cols.Add(dr[i].ToString());
                        }                        
                        result.Add(new Row(cols));
                    }
                    dr.Close();
                }

                tran.Commit();
                conn.Close();
                return new GenericResult(result, true, "","");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new GenericResult(null, false, e.Message,"");
            }
            
        }

        // deben usar execute_transaction cuando quieran retornar un solo valor de la bd, puede ser un string un integer un booleano, etc, pero
        //solo un valor!!!
        protected GenericResult execute_transaction(string function, List<Parameter> parameters)
        {
            try
            {
                // Connect to a PostgreSQL database
                NpgsqlConnection conn = new NpgsqlConnection(conn_string);
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(function,conn);
                command.CommandType = CommandType.StoredProcedure;
                foreach (Parameter p in parameters)
                {
                    command.Parameters.Add(new NpgsqlParameter(p.name, NpgsqlDbType.Text));
                    command.Parameters[p.name].Value = p.value;
                }
                // Execute the query and obtain the value of the first column of the first row
                var result = command.ExecuteScalar();

                Console.Write("{0}\n", result);
                conn.Close();
                return new GenericResult(null, true,"", result.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new GenericResult(null, false, e.Message,"");
            }
        }






    }
}
