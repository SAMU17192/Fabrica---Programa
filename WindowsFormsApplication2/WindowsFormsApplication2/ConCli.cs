using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class ConCli : Form
    {
        public ConCli()
        {
            InitializeComponent();
        }

        public void ConsultaGeral()
        {

            string strDeConexao = "Server=127.0.0.1;Database=indaya;User=root;Pwd=";
            try
            {
                MySqlConnection objConexao = new MySqlConnection();

                //classe que executa o comando SQL
                MySqlCommand objComando = new MySqlCommand();
                //recebe string SQL
                objConexao.ConnectionString = strDeConexao;


                objComando = new MySqlCommand("CALL SelectClientes()");

                objComando.Connection = objConexao;

                //abre a conexao
                objConexao.Open();

                MySqlDataReader Reading = objComando.ExecuteReader();
                while (Reading.Read())
                {

                    dgvclientes.Rows.Add(Reading[0], Reading[1]);
                }


            }
            catch (Exception erro)
            {
                erro.Message.ToString();

            }
        }
        public void ConsultaEspecifica()
        {

            dgvclientes.Rows.Clear();

            string strDeConexao = "Server=127.0.0.1;Database=indaya;User=root;Pwd=";
            try
            {
                MySqlConnection objConexao = new MySqlConnection();

                //classe que executa o comando SQL
                MySqlCommand objComando = new MySqlCommand();
                //recebe string SQL
                objConexao.ConnectionString = strDeConexao;


                objComando = new MySqlCommand("SELECT * FROM clientes WHERE CodigoCliente = '" + txtpesquisa.Text + "' OR NomeCliente LIKE '%" + txtpesquisa.Text + "%'");

                objComando.Parameters.AddWithValue("@Pesquisa", txtpesquisa.Text);




                objComando.Connection = objConexao;

                //abre a conexao
                objConexao.Open();

                MySqlDataReader Reading = objComando.ExecuteReader();
                while (Reading.Read())
                {

                    dgvclientes.Rows.Add(Reading[0], Reading[1]);
                }


            }
            catch (Exception erro)
            {
                erro.Message.ToString();

            }
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            ConsultaEspecifica();
        }

        private void ConCli_Load(object sender, EventArgs e)
        {
            ConsultaGeral();
        }
    }
}
