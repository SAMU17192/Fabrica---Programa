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
    public partial class ConUsu : Form
    {
        public ConUsu()
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


                objComando = new MySqlCommand("CALL SelectUsuarios()");

                objComando.Connection = objConexao;

                //abre a conexao
                objConexao.Open();

                MySqlDataReader Reading = objComando.ExecuteReader();
                while (Reading.Read())
                {

                    dgvusuarios.Rows.Add(Reading[0], Reading[1]);
                }


            }
            catch (Exception erro)
            {
                erro.Message.ToString();

            }
        }
        public void ConsultaEspecifica()
        {

            dgvusuarios.Rows.Clear();

            string strDeConexao = "Server=127.0.0.1;Database=indaya;User=root;Pwd=";
            try
            {
                MySqlConnection objConexao = new MySqlConnection();

                //classe que executa o comando SQL
                MySqlCommand objComando = new MySqlCommand();
                //recebe string SQL
                objConexao.ConnectionString = strDeConexao;


                objComando = new MySqlCommand("SELECT * FROM usuarios WHERE CodigoUsu = '" + txtpesquisa.Text + "' OR NomeUsu LIKE '%" + txtpesquisa.Text + "%' ");

                objComando.Parameters.AddWithValue("@Pesquisa", txtpesquisa.Text);




                objComando.Connection = objConexao;

                //abre a conexao
                objConexao.Open();

                MySqlDataReader Reading = objComando.ExecuteReader();
                while (Reading.Read())
                {

                    dgvusuarios.Rows.Add(Reading[0], Reading[1], Reading[2]);
                }


            }
            catch (Exception erro)
            {
                erro.Message.ToString();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaEspecifica();
        }

        private void ConUsu_Load(object sender, EventArgs e)
        {
            ConsultaGeral();
        }
    }
}
