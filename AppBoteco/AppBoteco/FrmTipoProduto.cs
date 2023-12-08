using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBoteco.Classes;

namespace AppBoteco
{
    public partial class FrmTipoProduto : Form
    {
        public FrmTipoProduto()
        {
            InitializeComponent();
        }

        private void FrmTipoProduto_Load(object sender, EventArgs e)
        {
            TipoProduto tipoProduto = new TipoProduto();
            List<TipoProduto> tipoProdutos = tipoProduto.listatipoproduto();
            dgvTipoProduto.DataSource = tipoProdutos;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTipoProduto.Text == "")
                {
                    MessageBox.Show("Por favor, preencha o campo Tipo do Produto!", "Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActiveControl = txtTipoProduto;
                    return;
                }
                else
                {
                    TipoProduto tipoProduto = new TipoProduto();
                    if (tipoProduto.RegistroRepetido(txtTipoProduto.Text) == true)
                    {
                        MessageBox.Show("Tipo do produto já existe em nossa base de dados!", "Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTipoProduto.Text = "";
                        this.ActiveControl= txtTipoProduto;
                    }
                    else
                    {
                        tipoProduto.Inserir(txtTipoProduto.Text);
                        MessageBox.Show("Tipo do produto inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoProduto.Text = "";
                        this.ActiveControl = txtTipoProduto;
                        List<TipoProduto> tipoProdutos = tipoProduto.listatipoproduto();
                        dgvTipoProduto.DataSource = tipoProdutos;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor digite um ID para realizar a busca!", "Localizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = txtId;
                    return;
                }
                else
                {
                    int Id = Convert.ToInt32(txtId.Text.Trim());
                    TipoProduto tipoProduto = new TipoProduto();
                    tipoProduto.Localizar(Id);
                    txtTipoProduto.Text = tipoProduto.tipo;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Localização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                TipoProduto tipoProduto = new TipoProduto();
                tipoProduto.Atualizar(Id, txtTipoProduto.Text);
                MessageBox.Show("Tipo do Produto atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = "";
                txtTipoProduto.Text = "";
                this.ActiveControl = txtTipoProduto;
                List<TipoProduto> tipoProdutos = tipoProduto.listatipoproduto();
                dgvTipoProduto.DataSource = tipoProdutos;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                TipoProduto tipoProduto = new TipoProduto();
                tipoProduto.Excluir(Id);
                MessageBox.Show("Tipo do produto excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = "";
                txtTipoProduto.Text = "";
                this.ActiveControl = txtTipoProduto;
                List<TipoProduto> tipoProdutos = tipoProduto.listatipoproduto();
                dgvTipoProduto.DataSource = tipoProdutos;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTipoProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTipoProduto.Rows[e.RowIndex];
                row.Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtTipoProduto.Text = row.Cells[1].Value.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
