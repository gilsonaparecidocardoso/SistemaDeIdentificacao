using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeIdentificacao.DML
{
    public class Logradouro
    {
        /// <summary>
        /// LogradouroID
        /// </summary>
        public long LogradouroID { get; set; }

        /// <summary>
        /// Descricao
        /// </summary>
        public string Descricao { get; set; }

        public Logradouro(long logradouroID, string descricao)
        {
            LogradouroID = logradouroID;
            Descricao = descricao;
        }
    }
}
