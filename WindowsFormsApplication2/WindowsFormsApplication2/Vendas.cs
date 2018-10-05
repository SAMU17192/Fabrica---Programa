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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }
        public void ConsultaEspecifica()
        {

            txtnome.Clear();
            txtdescricao.Clear();

            string strDeConexao = "Server=127.0.0.1;Database=indaya;User=root;Pwd=";
            try
            {
                MySqlConnection objConexao = new MySqlConnection();

                //classe que executa o comando SQL
                MySqlCommand objComando = new MySqlCommand();
                //recebe string SQL
                objConexao.ConnectionString = strDeConexao;


                objComando = new MySqlCommand("SELECT * FROM produtos WHERE CodigoProduto = '" + txtpesquisa.Text + "'");

                objComando.Parameters.AddWithValue("@Pesquisa", txtpesquisa.Text);




                objComando.Connection = objConexao;

                //abre a conexao
                objConexao.Open();

                MySqlDataReader Reading = objComando.ExecuteReader();
                while (Reading.Read())
                {

                    txtnome.Text = Convert.ToString(Reading[1]);
                    txtdescricao.Text = Convert.ToString(Reading[2]);
                }


            }
            catch (Exception erro)
            {
                erro.Message.ToString();

            }
        }


        public void ConsultaEspecifica2()
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
                DataTable tabela = new DataTable();

                tabela.Load(Reading);

                DataRow linha = tabela.NewRow();
                linha["NomeCliente"] = "";
                tabela.Rows.InsertAt(linha, 0);

                this.cbocliente.DataSource = tabela;
                this.cbocliente.ValueMember = "CodigoCliente";
                this.cbocliente.DisplayMember = "NomeCliente";

                Reading.Close();
                Reading.Dispose();



                while (Reading.Read())
                {

                    txtnome.Text = Convert.ToString(Reading[1]);
                    txtdescricao.Text = Convert.ToString(Reading[2]);
                }


            }
            catch (Exception erro)
            {
                erro.Message.ToString();

            }
        }












        public void Vender(double valorfinal, string idcliente,int quantidade, int idproduto, string data, string Nota)
        {

            string strDeConexao = "Server=127.0.0.1;Database=indaya;User=root;Pwd=";
            try
            {
                MySqlConnection objConexao = new MySqlConnection();

                //classe que executa o comando SQL
                MySqlCommand objComando = new MySqlCommand();
                //recebe string SQL
                objConexao.ConnectionString = strDeConexao;


                objComando = new MySqlCommand("CALL AddVenda(@Valor, @Cliente, @Qtd, @Produto, @DataVenda, @Nota)");
                objComando.Parameters.AddWithValue("@Valor", valorfinal);
                objComando.Parameters.AddWithValue("@Cliente", idcliente);
                objComando.Parameters.AddWithValue("@Qtd", quantidade);
                objComando.Parameters.AddWithValue("@Produto", idproduto);
                objComando.Parameters.AddWithValue("@DataVenda", data);
                objComando.Parameters.AddWithValue("@Nota", Nota);
                objComando.Connection = objConexao;

                //abre a conexao
                objConexao.Open();

                MySqlDataReader Reading = objComando.ExecuteReader();
                DataTable tabela = new DataTable();

                tabela.Load(Reading);

                DataRow linha = tabela.NewRow();
                linha["NomeCliente"] = "";
                tabela.Rows.InsertAt(linha, 0);

                this.cbocliente.DataSource = tabela;
                this.cbocliente.ValueMember = "CodigoCliente";
                this.cbocliente.DisplayMember = "NomeCliente";

                Reading.Close();
                Reading.Dispose();



                while (Reading.Read())
                {

                    txtnome.Text = Convert.ToString(Reading[1]);
                    txtdescricao.Text = Convert.ToString(Reading[2]);
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

        private void cbocliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString("dd/MM/yyyy");
            lbldata.Text = data;
            ConsultaEspecifica2();
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            
            if (txtnome.Text != "" && int.Parse(txtquantidade.Text) != 0 && txtvalor.Text != "")
            {

                int quantidade = int.Parse(txtquantidade.Text);
                double valor = Convert.ToDouble(txtvalor.Text);
                double valorfinal = quantidade * valor;
                if (Convert.ToString(cbocliente.SelectedValue) != "")
                {

                    string data = DateTime.Now.ToString("dd/MM/yyyy");
                    string idcliente = Convert.ToString(cbocliente.SelectedValue);
                    int idproduto = int.Parse(txtpesquisa.Text);
                    string nota = txtnota.Text;
                    Vender(valorfinal, idcliente, quantidade, idproduto, data, nota);
                    MessageBox.Show("Venda feita com sucesso!");

                }    

            }
            
        }
    }
}
