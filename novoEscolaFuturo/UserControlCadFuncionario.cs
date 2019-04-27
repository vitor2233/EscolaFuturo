using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novoEscolaFuturo
{
    public partial class UserControlCadFuncionario : UserControl
    {
        ClassFuncionario funcionario = new ClassFuncionario();

        int codFuncionarioClicado = 0;
        public UserControlCadFuncionario()
        {
            InitializeComponent();
            dgvCadFunci.DataSource = funcionario.RetFuncionarios();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = mskCpf.Text;
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Endereco = txtEndereco.Text;
            if(cboTipo.Text == "Diretor")
            {
                cboTipo.Text = "1";
            }else if(cboTipo.Text == "Pedagogo")
            {
                cboTipo.Text = "2";
            }
            else if(cboTipo.Text == "Coordenador")
            {
                cboTipo.Text = "3";
            }
            else if(cboTipo.Text == "Secretária")
            {
                cboTipo.Text = "4";
            }
            else if(cboTipo.Text == "Bibliotecário")
            {
                cboTipo.Text = "5";
            }
            funcionario.Tipo = int.Parse(cboTipo.Text);

            if (funcionario.Inserir() == true)
            {
                MessageBox.Show("funcionario cadastrado com sucesso!");
                dgvCadFunci.DataSource = funcionario.RetFuncionarios();
            }
            else
            {
                MessageBox.Show("Erro ao cadastraro funcionario!");
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = mskCpf.Text;
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Tipo = int.Parse(cboTipo.Text);


            if (funcionario.Editar(codFuncionarioClicado) == true)
            {
                MessageBox.Show("Funcionário foi editado com sucesso!");
                dgvCadFunci.DataSource = funcionario.RetFuncionarios();
            }
            else
            {
                MessageBox.Show("Erro ao editar o funcionário!");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = mskCpf.Text;
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Tipo = int.Parse(cboTipo.Text);

            if (funcionario.Excluir(codFuncionarioClicado) == true)
            {
                MessageBox.Show("O funcionário foi excluído com sucesso!");
                dgvCadFunci.DataSource = funcionario.RetFuncionarios();
            }

        }

        private void DgvCadFunci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCadFunci.Rows[e.RowIndex].Cells["codFuncionario"].
                       Value.ToString() != "")
                {
                    codFuncionarioClicado = int.Parse(dgvCadFunci.Rows
                        [e.RowIndex].Cells["codFuncionario"].Value.ToString());
                }

                mskCpf.Text = dgvCadFunci.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                txtEndereco.Text = dgvCadFunci.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
                txtNome.Text = dgvCadFunci.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                cboTipo.Text = dgvCadFunci.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
                mskTelefone.Text = dgvCadFunci.Rows[e.RowIndex].Cells["telefone"].Value.ToString();


                dgvCadFunci.DataSource = funcionario.RetFuncionarios();
            }
        }
    }
}
