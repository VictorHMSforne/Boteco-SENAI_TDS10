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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxCEP_Click(object sender, EventArgs e)
        {
            BuscaCEP cEP = new BuscaCEP();
            cEP.Busca(txtCep.Text);
            txtEndereco.Text = cEP.endereco.ToString();
            txtBairro.Text = cEP.bairro.ToString();
            txtCidade.Text = cEP.cidade.ToString();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            List<Funcionario> funcionarios = funcionario.listafuncionario();
            dgvFuncionario.DataSource = funcionarios;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mkCpf.Text == "" || mkCelular.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Funcionario funcionario = new Funcionario();
                if (funcionario.RegistroRepetido(txtNome.Text, mkCpf.Text) == true)
                {
                    MessageBox.Show("Funcionario já existe em nossa base de dados!", "Funcionário Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    mkCpf.Text = "";
                    txtEndereco.Text = "";
                    txtComplemento.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtCep.Text = "";
                    mkCelular.Text = "";
                    cbxCargo.Text = "";
                    return;
                }
                else
                {
                    funcionario.Inserir(txtNome.Text, mkCpf.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, mkCelular.Text, txtCep.Text, cbxCargo.Text, txtComplemento.Text);
                    MessageBox.Show("Funcionário inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Funcionario> funcionarios = funcionario.listafuncionario();
                    dgvFuncionario.DataSource = funcionarios;
                    txtNome.Text = "";
                    mkCpf.Text = "";
                    txtEndereco.Text = "";
                    txtComplemento.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtCep.Text = "";
                    mkCelular.Text = "";
                    cbxCargo.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Atualizar(Id, txtNome.Text, mkCpf.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, mkCelular.Text, txtCep.Text, cbxCargo.Text, txtComplemento.Text);
                MessageBox.Show("Funcionário atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> funcionarios = funcionario.listafuncionario();
                dgvFuncionario.DataSource = funcionarios;
                txtId.Text = "";
                txtNome.Text = "";
                mkCpf.Text = "";
                txtEndereco.Text = "";
                txtComplemento.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtCep.Text = "";
                mkCelular.Text = "";
                cbxCargo.Text = "";
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
                Funcionario funcionario = new Funcionario();
                funcionario.Excluir(Id);
                MessageBox.Show("Funcionário excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> funcionarios = funcionario.listafuncionario();
                dgvFuncionario.DataSource = funcionarios;
                txtId.Text = "";
                txtNome.Text = "";
                mkCpf.Text = "";
                txtEndereco.Text = "";
                txtComplemento.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtCep.Text = "";
                mkCelular.Text = "";
                cbxCargo.Text = "";
                this.ActiveControl = txtNome;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Funcionario funcionario = new Funcionario();
                funcionario.Localizar(Id);
                txtNome.Text = funcionario.nome;
                mkCpf.Text = funcionario.cpf;
                txtEndereco.Text = funcionario.endereco;
                txtComplemento.Text = funcionario.complemento;
                txtBairro.Text = funcionario.bairro;
                txtCidade.Text = funcionario.cidade;
                txtCep.Text = funcionario.cep;
                mkCelular.Text = funcionario.celular;
                cbxCargo.Text = funcionario.cargo;
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

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFuncionario.Rows[e.RowIndex];
                this.dgvFuncionario.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                mkCpf.Text = row.Cells[2].Value.ToString();
                txtEndereco.Text = row.Cells[3].Value.ToString();
                txtBairro.Text = row.Cells[3].Value.ToString();
                txtCidade.Text = row.Cells[3].Value.ToString();
                mkCelular.Text = row.Cells[3].Value.ToString();
                txtCep.Text = row.Cells[3].Value.ToString();
                cbxCargo.Text = row.Cells[3].Value.ToString();
                txtComplemento.Text = row.Cells[3].Value.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
