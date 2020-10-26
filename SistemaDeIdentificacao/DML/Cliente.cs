using System.Collections.Generic;

namespace SistemaDeIdentificacao.DML
{
    public class Cliente
    {
        public Cliente() { }

        public Cliente(long clienteId, string nome, string email, List<Logradouro> logradouros)
        {
            ClienteId = clienteId;
            Nome = nome;
            Email = email;
            Logradouros = logradouros;
        }

        /// <summary>
        /// ClienteId
        /// </summary>
        public long ClienteId { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Logradouros
        /// </summary>
        public List<Logradouro> Logradouros { get; set; }
    }
}
