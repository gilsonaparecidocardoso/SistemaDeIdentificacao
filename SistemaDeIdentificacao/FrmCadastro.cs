using Newtonsoft.Json;
using SistemaDeIdentificacao.DML;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SistemaDeIdentificacao
{
    public partial class FrmCadastro : Form
    {
        public static string webserviceCliente = "http://localhost:49686/Api/Cliente";

        public FrmCadastro()
        {
            InitializeComponent();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pctLogotipo.Image = null;
            txtNome.Text = "";
            txtEmail.Text = "";
            cmbLogradouro.SelectedIndex = -1;
            cmbLogradouro.Text = "";
        }

        private async void RetornarDados()
        {
            string URI = webserviceCliente;
            try { 
            using (var cliente = new HttpClient())
            {
                using (var response = await cliente.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ClienteJsonString = await response.Content.ReadAsStringAsync();
                        //dataGridView1.DataSource = JsonConvert.DeserializeObject<Cliente[]>(ClienteJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter os dados: " + response.StatusCode);
                    }
                }
            }
            }catch(Exception e)
            {
                MessageBox.Show("Falha: " + e.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            IncluirCliente();
            //AtualizarCliente(1);
        }

        private async void IncluirCliente()
        {
            string URI = webserviceCliente;
            List<Logradouro> arrLog = new List<Logradouro>();
            arrLog.Add(new Logradouro(1, "Rua Angélica, 144"));
            arrLog.Add(new Logradouro(1, "Rua Augusta, 2000"));
            arrLog.Add(new Logradouro(1, "Rua Consolação, 166"));
            Cliente cliente = new Cliente(1, "José Augusto", "jose.augusto@gmail.com", arrLog);

            try
            {
                using (var httpCliente = new HttpClient())
                {
                    var serializedFuncionario = JsonConvert.SerializeObject(cliente);
                    var content = new StringContent(serializedFuncionario, Encoding.UTF8, "application/json");
                    var result = await httpCliente.PostAsync(URI, content);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha: " + e.Message);
            }
            RetornarDados();
        }

        private async void AtualizarClientes(int cod_funcionario)
        {
            string URI = webserviceCliente;
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text.Trim();
            cliente.Email = txtEmail.Text.ToLower().Trim();
            List<Logradouro> arrLog = null;
            arrLog.Add(new Logradouro(long.Parse(cmbLogradouro.ValueMember), cmbLogradouro.DisplayMember));
            cliente.Logradouros = arrLog;
            
            using (var httpCliente = new HttpClient())
            {
                var serializedFuncionario = JsonConvert.SerializeObject(httpCliente);
                var content = new StringContent(serializedFuncionario, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = await httpCliente.PutAsync(URI + "?cod=" + cod_funcionario, content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente atualizado");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o cliente: " + responseMessage.StatusCode);
                }
            }
            RetornarDados();
        }

        private void btnLogotipo_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Arquivo JPG(*.jpg)|*.jpg",
                Title = "Selecionar Logotipo"
            };
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);                
                pctLogotipo.Image = (Image)image;
            }
        }

    }

}
