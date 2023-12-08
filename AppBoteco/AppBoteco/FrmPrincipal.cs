using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AppBoteco
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            FrmSplash splash = new FrmSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Deseja realmente sair?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pbxProdutos_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.Show();
        }

        private void pbxFuncionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.Show();
        }

        private void pbxClientes_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void pbxTipoProduto_Click(object sender, EventArgs e)
        {
            FrmTipoProduto tipoProduto = new FrmTipoProduto();
            tipoProduto.Show();
        }

        private void tipoDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoProduto tipoProduto = new FrmTipoProduto();
            tipoProduto.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenda venda = new FrmVenda();
            venda.Show();
        }

        private void pbxVendas_Click(object sender, EventArgs e)
        {
            FrmVenda venda = new FrmVenda();
            venda.Show();
        }
    }
}
