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
    public partial class ConProd : Form
    {
        public ConProd()
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


                objComando = new MySqlCommand("CALL SelectProdutos()");

                objComando.Connection = objConexao;

                //abre a conexao
                objConexao.Open();

                MySqlDataReader Reading = objComando.ExecuteReader();
                while (Reading.Read())
                {

                    dgvprodutos.Rows.Add(Reading[0], Reading[1], Reading[2]);
                }


            }
            catch (Exception erro)
            {
                erro.Message.ToString();

            }
        }

        public void ConsultaEspecifica()
        {

            dgvprodutos.Rows.Clear();

            string strDeConexao = "Server=127.0.0.1;Database=indaya;User=root;Pwd=";
            try
            {
                MySqlConnection objConexao = new MySqlConnection();

                //classe que executa o comando SQL
                MySqlCommand objComando = new MySqlCommand();
                //recebe string SQL
                objConexao.ConnectionString = strDeConexao;


                objComando = new MySqlCommand("SELECT * FROM produtos WHERE CodigoProduto = '"+txtpesquisa.Text+"' OR NomeProduto LIKE '%" + txtpesquisa.Text+"%' OR DescricaoProduto LIKE '%"+txtpesquisa.Text+"%'");

                objComando.Parameters.AddWithValue("@Pesquisa", txtpesquisa.Text);




                objComando.Connection = objConexao;

                //abre a conexao
                objConexao.Open();

                MySqlDataReader Reading = objComando.ExecuteReader();
                while (Reading.Read())
                {

                    dgvprodutos.Rows.Add(Reading[0], Reading[1], Reading[2]);
                }


            }
            catch (Exception erro)
            {
                erro.Message.ToString();

            }
        }

        private void ConProd_Load(object sender, EventArgs e)
        {
            ConsultaGeral();
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            ConsultaEspecifica();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
