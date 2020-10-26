using SistemaDeIdentificacao.DB;
using SistemaDeIdentificacao.DML;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SistemaDeIdentificacao.DAO
{
    internal class DAOCliente : ClsBanco
        {
        /// <summary>
        /// Inclui um novo cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        internal long Incluir(Cliente cliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("Nome", cliente.Nome));
            parametros.Add(new SqlParameter("Sobrenome", cliente.Email));      

            DataSet ds = base.ExecutaProcedure("SP_ClienteInc", parametros);
            long ret = 0;
            if (ds.Tables[0].Rows.Count > 0)
                long.TryParse(ds.Tables[0].Rows[0][0].ToString(), out ret);
            return ret;
        }

        /// <summary>
        /// Inclui um novo cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        internal Cliente Consultar(long Id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("Id", Id));

            DataSet ds = base.ExecutaProcedure("SP_ClienteCons", parametros);
            List<Cliente> cli = Converter(ds);

            return cli.FirstOrDefault();
        }

        internal bool VerificarExistencia(string Email)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("Email", CPF));

            DataSet ds = base.ExecutaProcedure("SP_VerificaCliente", parametros);

            return ds.Tables[0].Rows.Count > 0;
        }

        internal List<Cliente> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, out int qtd)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("iniciarEm", iniciarEm));
            parametros.Add(new SqlParameter("quantidade", quantidade));
            parametros.Add(new SqlParameter("campoOrdenacao", campoOrdenacao));
            parametros.Add(new SqlParameter("crescente", crescente));

            DataSet ds = base.ExecutaProcedure("SP_ClientePesq", parametros);
            List<Cliente> cli = Converter(ds);

            int iQtd = 0;

            if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                int.TryParse(ds.Tables[1].Rows[0][0].ToString(), out iQtd);

            qtd = iQtd;

            return cli;
        }

        /// <summary>
        /// Lista todos os clientes
        /// </summary>
        internal List<Cliente> Listar()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("Id", 0));

            DataSet ds = base.ExecutaProcedure("SP_ClienteCons", parametros);
            List<Cliente> cli = Converter(ds);

            return cli;
        }

        /// <summary>
        /// Altera o cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        internal void Alterar(Cliente cliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("Nome", cliente.Nome));
            parametros.Add(new SqlParameter("Sobrenome", cliente.Email));

            base.Executar("SP_ClienteAlt", parametros);

            parametros.Add(new SqlParameter("clienteID", cliente.ClienteId));
            //parametros.Add(new SqlParameter("LogradouroID", retornaLogradourosCombo()));

            base.Executar("SP_ClienteAltLogradouro", parametros);
        }


        /// <summary>
        /// Excluir Cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        internal void Excluir(long clienteId)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("ClienteId", clienteId));

            base.Executar("SP_ClienteExc", parametros);
        }

        private List<Cliente> Converter(DataSet ds)
        {
            List<Cliente> lista = new List<Cliente>();
            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Cliente cli = new Cliente();
                    cli.ClienteId = row.Field<int>("ClienteID");
                    cli.Nome = row.Field<string>("Nome");
                    cli.Email = row.Field<string>("Email");
                    //cli.Logradouros = retornaLogradouros(row.Field<int>("ClienteID"));
                    lista.Add(cli);
                }
            }

            return lista;
        }
    }
}
