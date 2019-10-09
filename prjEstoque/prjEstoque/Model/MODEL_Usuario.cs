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
    class MODEL_Usuario
    {
            private DBUtils db;

            public MODEL_Usuario()
            {
                db = new DBUtils();
            }

            public List<Usuario> GetAll()
            {
                string query = "SELECT * FROM tbUsuario";
                List<Usuario> list = new List<Usuario>();

                try
                {
                    SqlDataReader reader = db.CallExecuteReader(query);
                    while (reader.Read())
                    {
                        Usuario c = new Usuario();

                        c.CodUsuario = int.Parse(reader["CodUsuario"].ToString());
                        c.Cpf = reader["cpf"].ToString();
                        c.Nome = reader["nome"].ToString();
                        c.Cnh = reader["cnh"].ToString();
                        c.DataNascimento = DateTime.Parse(reader["dataNascimento"].ToString());

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
        
            public int Insert(Usuario c)
            {
                string query = "INSERT INTO tbUsuario VALUES(@nome, @cpf, @cnh, @dataNascimento)";

                try
                {
                    return db.CallExecuteNonQuery(query, new SqlParameter("@nome", c.Nome),
                                                         new SqlParameter("@cpf", c.Cpf),
                                                         new SqlParameter("@cnh", c.Cnh),
                                                         new SqlParameter("@dataNascimento", c.DataNascimento));
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }

            public int Update(Usuario c)
            {
                string query = "UPDATE tbUsuario SET nome = @nome, cpf = @cpf, cnh = @cnh, dataNascimento = @dataNascimento WHERE CodUsuario = @codUsuario";

                try
                {
                    return db.CallExecuteNonQuery(query, new SqlParameter("@nome", c.Nome),
                                                      new SqlParameter("@cpf", c.Cpf),
                                                      new SqlParameter("@cnh", c.Cnh),
                                                      new SqlParameter("@dataNascimento", c.DataNascimento),
                                                      new SqlParameter("@codUsuario", c.CodUsuario));
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }

            public int Delete(int cod)
            {
                string query = "DELETE FROM tbUsuario WHERE CodUsuario = @codUsuario";
                try
                {
                    return db.CallExecuteNonQuery(query, new SqlParameter("@codUsuario", cod));
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
    }
}
