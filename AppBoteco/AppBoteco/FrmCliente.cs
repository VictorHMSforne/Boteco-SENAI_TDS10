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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtxtCpf.Text == "" || mtxtCelular.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Cliente cliente = new Cliente();
                if (cliente.RegistroRepetido(mtxtCpf.Text) == true)
                {
                    MessageBox.Show("Cliente já existe em nossa base de dados!", "Cliente Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    mtxtCpf.Text = "";
                    mtxtCelular.Text = "";
                    return;
                }
                else
                {
                    cliente.Inserir(txtNome.Text, mtxtCpf.Text, mtxtCelular.Text);
                    MessageBox.Show("Cliente inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Cliente> clientes = cliente.listacliente();
                    dgvCliente.DataSource = clientes;
                    txtNome.Text = "";
                    mtxtCpf.Text = "";
                    mtxtCelular.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor, digite um ID para localizar!", "Sem ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Cliente cliente = new Cliente();
                cliente.Localizar(Id);
                txtNome.Text = cliente.nome;
                mtxtCelular.Text = cliente.celular;
                mtxtCpf.Text = cliente.cpf;
                if (txtNome.Text != null)
                {
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
                Cliente cliente = new Cliente();
                cliente.Atualizar(Id, txtNome.Text, mtxtCpf.Text, mtxtCelular.Text);
                MessageBox.Show("Cliente atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Cliente> clientes = cliente.listacliente();
                dgvCliente.DataSource = clientes;
                txtId.Text = "";
                txtNome.Text = "";
                mtxtCelular.Text = "";
                mtxtCpf.Text = "";
                this.ActiveControl = txtNome;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Cliente cliente = new Cliente();
                cliente.Excluir(Id);
                MessageBox.Show("Cliente excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Cliente> clientes = cliente.listacliente();
                dgvCliente.DataSource = clientes;
                txtId.Text = "";
                txtNome.Text = "";
                mtxtCelular.Text = "";
                mtxtCpf.Text = "";
                this.ActiveControl = txtNome;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                this.dgvCliente.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                mtxtCpf.Text = row.Cells[2].Value.ToString();
                mtxtCelular.Text = row.Cells[3].Value.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
