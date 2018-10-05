using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Menu : Form
    {
        public int I;
        public String N;
        public String S;
        public Menu(int IdUsuario, String NomeUsuario, String SenhaUsuario)
        {
            InitializeComponent();

            I = IdUsuario;
            N = NomeUsuario;
            S = SenhaUsuario;
            lblusuario.Text = N;
        }

        private void btnentraestoque_Click(object sender, EventArgs e)
        {
            EntradaEst EntradaEst = new EntradaEst();
            EntradaEst.ShowDialog();
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            Vendas Vendas = new Vendas();
            Vendas.ShowDialog();
        }

        private void btnconvenda_Click(object sender, EventArgs e)
        {
            ConVenda ConVenda = new ConVenda();
            ConVenda.ShowDialog();
        }

        private void btncadprod_Click(object sender, EventArgs e)
        {
            CadProd CadProd = new CadProd();
            CadProd.ShowDialog();
        }

        private void btnconprod_Click(object sender, EventArgs e)
        {
            ConProd ConProd = new ConProd();
            ConProd.ShowDialog();
        }

        private void btncadusu_Click(object sender, EventArgs e)
        {
            CadUsu CadUsu = new CadUsu();
            CadUsu.ShowDialog();
        }

        private void btnconusu_Click(object sender, EventArgs e)
        {
            ConUsu ConUsu = new ConUsu();
            ConUsu.ShowDialog();
        }

        private void btncadcli_Click(object sender, EventArgs e)
        {
            CadCli CadCli = new CadCli();
            CadCli.ShowDialog();
        }

        private void btnconcli_Click(object sender, EventArgs e)
        {
            ConCli ConCli = new ConCli();
            ConCli.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
