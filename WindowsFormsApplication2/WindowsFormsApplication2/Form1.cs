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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void PesqueNome()
        {

            string strDeConexao = "Server=127.0.0.1;Database=indaya;User=root;Pwd=";

            MySqlConnection objConexao = new MySqlConnection();

            //classe que executa o comando SQL
            MySqlCommand objComando = new MySqlCommand();
            //recebe string SQL
            objConexao.ConnectionString = strDeConexao;


            objComando = new MySqlCommand("CALL LoginUsuario(@Login, @Senha)");
            objComando.Parameters.AddWithValue("@Login", txtusuario.Text);
            objComando.Parameters.AddWithValue("@Senha", txtsenha.Text);



            objComando.Connection = objConexao;

            //abre a conexao
            objConexao.Open();

            MySqlDataReader Reading = objComando.ExecuteReader();

            while (Reading.Read())
            {
                MessageBox.Show("Tooop: " + Reading[0].ToString() + " Tooop: " + Reading[1].ToString());
                if (Reading[1].ToString() == txtusuario.Text && Reading[2].ToString() == txtsenha.Text)
                {

                    Menu Menu = new Menu(int.Parse(Reading[0].ToString()), Reading[1].ToString(), Reading[2].ToString());
                    Menu.ShowDialog();
                    

                }

            }


        }


        private void btnentrar_Click(object sender, EventArgs e)
        {
            PesqueNome();
        }
    }
}
