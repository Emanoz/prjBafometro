using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data;
using System.Data.SqlClient;

namespace prjEstoque.Model
{
    class MODEL_Ocorrencia
    {
        private DBUtils db;

        public MODEL_Ocorrencia()
        {
            db = new DBUtils();
        }

        public List<Ocorrencia> GetAll()
        {
            string query = "SELECT * FROM tbOcorrencia";
            List<Ocorrencia> list = new List<Ocorrencia>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while (reader.Read())
                {
                    Ocorrencia c = new Ocorrencia();

                    c.CodOcorrencia = int.Parse(reader["codOcorrencia"].ToString());
                    c.CodUsuario = int.Parse(reader["codUsuario"].ToString());
                    c.ValorAlcool = double.Parse(reader["valorAlcool"].ToString());
                    c.DataOcorrencia = DateTime.Parse(reader["dataOcorrencia"].ToString());

                    list.Add(c);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return list;
        }

        public int Insert(Ocorrencia c)
        {
            string query = "INSERT INTO tbOcorrencia VALUES(@codUsuario, @valorAlcool, @dataOcorrencia)";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@codUsuario", c.CodUsuario),
                                                     new SqlParameter("@valorAlcool", c.ValorAlcool),
                                                     new SqlParameter("@dataOcorrencia", c.DataOcorrencia));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Update(Ocorrencia c)
        {
            string query = "UPDATE tbOcorrencia SET codUsuario = @codUsuario, valorAlcool = @valorAlcool, dataOcorrencia = @dataOcorrencia WHERE codOcorrencia = @codOcorrencia";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@codUsuario", c.CodUsuario),
                                                  new SqlParameter("@valorAlcool", c.ValorAlcool),
                                                  new SqlParameter("@dataOcorrencia", c.DataOcorrencia),
                                                  new SqlParameter("@codOcorrencia", c.CodOcorrencia));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Delete(int cod)
        {
            string query = "DELETE FROM tbOcorrencia WHERE codOcorrencia = @codOcorrencia";
            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@codOcorrencia", cod));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
