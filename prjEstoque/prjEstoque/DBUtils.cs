using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque
{
    class DBUtils
    {
        private string connString = @"Data Source=PC-NANA\SQLEXPRESS;Initial Catalog=bdBafometro;Integrated Security=True";

        public DBUtils()
        {
             
        }

        public void OpenConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public int CallExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddRange(parameters);
                        OpenConnection(conn);
                        int rows = cmd.ExecuteNonQuery();
                        CloseConnection(conn);
                        return rows;
                    }
                }
            }
            catch(SqlException sqlex)
            {

                throw new Exception("Erro ao executar o comando!\n'" + sqlex + "'");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public SqlDataReader CallExecuteReader(string query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    OpenConnection(conn);
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
       
            }
            catch (SqlException sqlex)
            {

                throw new Exception("Erro ao executar o comando!\n'" + sqlex + "'");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
