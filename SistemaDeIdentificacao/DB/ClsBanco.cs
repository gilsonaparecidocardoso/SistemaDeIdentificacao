using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaDeIdentificacao.DB
{
    internal class ClsBanco
    {
        internal void Executar(string NomeProcedure, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexao = RetornaConnection();
            comando.Connection = conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NomeProcedure;
            foreach (var item in parametros)
                comando.Parameters.Add(item);

            conexao.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        internal DataSet ExecutaProcedure(string NomeProcedure, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand();
            DataSet ds = null;

            try
            {
                comando.Connection = RetornaConnection();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = NomeProcedure;

                foreach (var item in parametros)
                    comando.Parameters.Add(item);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                ds = new DataSet();
                comando.Connection.Open();
                adapter.Fill(ds);
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            return ds;
        }

        private static SqlConnection RetornaConnection()
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = "DESKTOP-1VKT8KS\\SQLEXPRESS";
            csb.InitialCatalog = "Sdi";
            csb.IntegratedSecurity = true;

            SqlConnection connection = new SqlConnection(csb.ConnectionString);
            return connection;
        }
    }
}
