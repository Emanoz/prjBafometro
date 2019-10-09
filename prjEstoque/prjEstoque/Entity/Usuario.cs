using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    class Usuario
    {
        public Usuario()
        {

        }

        public Usuario(int codUsuario, string nome, string cpf, string cnh, DateTime dataNascimento)
        {
            CodUsuario = codUsuario;
            Nome = nome;
            Cpf = cpf;
            Cnh = cnh;
            DataNascimento = dataNascimento;
        }

        public int CodUsuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
