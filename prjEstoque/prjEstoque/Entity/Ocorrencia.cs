using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    class Ocorrencia
    {
        public Ocorrencia()
        {

        }

        public Ocorrencia(int codOcorrencia, int codUsuario, double valorAlcool, DateTime dataOcorrencia)
        {
            CodOcorrencia = codOcorrencia;
            CodUsuario = codUsuario;
            ValorAlcool = valorAlcool;
            DataOcorrencia = dataOcorrencia;
        }

        public int CodOcorrencia { get; set; }
        public int CodUsuario { get; set; }
        public double ValorAlcool { get; set; }
        public DateTime DataOcorrencia { get; set; }
    }
}
