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
    public partial class CadUsu : Form
    {
        public CadUsu()
        {
            InitializeComponent();
        }
        public bool CadastroUsuario()
        {

            string strDeConexao = "Server=127.0.0.1;Database=indaya;User=root;Pwd=";
            try
            {
                MySqlConnection objConexao = new MySqlConnection();

                //classe que executa o comando SQL
                MySqlCommand objComando = new MySqlCommand();
                //recebe string SQL
                objConexao.ConnectionString = strDeConexao;


                objComando = new MySqlCommand("CALL AddUsuario(@Nome,@Descricao)");

                objComando.Parameters.AddWithValue("@Nome", txtnome.Text);
                objComando.Parameters.AddWithValue("@Descricao", txtsenha.Text);

                objComando.Connection = objConexao;

                //abre a conexao
                objConexao.Open();

                objComando.ExecuteNonQuery();
                return true;

            }
            catch (Exception erro)
            {
                erro.Message.ToString();
                return false;
            }

        }

        private void CadUsu_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (CadastroUsuario())
            {
                MessageBox.Show("Cadastrado Com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro Ao Cadastrar");
            }
        }
    }
}
