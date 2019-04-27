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
    public partial class UserControlCadProfessor : UserControl
    {
        ClassProfessor professor = new ClassProfessor();
        int codProfessorClicado = 0;
        public UserControlCadProfessor()
        {
            InitializeComponent();
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            professor.Cpf = mskCpf.Text;
             professor.Nome = txtNome.Text;
            professor.Telefone = mskTelefone.Text;
            professor.Endereco = txtEndereco.Text;
            professor.Curso = txtCurso.Text;

            if (professor.Inserir() == true)
            {
                MessageBox.Show("Professor cadastrado com sucesso!");
                dgvCadProf.DataSource = professor.RetProfessor();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o professor!");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            professor.Cpf = mskCpf.Text;
            professor.Nome = txtNome.Text;
            professor.Telefone = mskTelefone.Text;
            professor.Endereco = txtEndereco.Text;
            professor.Curso = txtCurso.Text;


            if (professor.Editar(codProfessorClicado) == true)
            {
                MessageBox.Show("Professor foi editado com sucesso!");
                dgvCadProf.DataSource = professor.RetProfessor();
            }
            else
            {
                MessageBox.Show("Erro ao editar o professor!");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
           

            if (professor.Excluir(codProfessorClicado) == true)
            {
                professor.Cpf = mskCpf.Text;
                professor.Nome = txtNome.Text;
                professor.Telefone = mskTelefone.Text;
                professor.Endereco = txtEndereco.Text;
                professor.Curso = txtCurso.Text;

                MessageBox.Show("O professor foi excluído com sucesso!");
                dgvCadProf.DataSource = professor.RetProfessor();
            }
        }

        private void DgvCadProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCadProf.Rows[e.RowIndex].Cells["codProfessor"].
                       Value.ToString() != "")
                {
                    codProfessorClicado = int.Parse(dgvCadProf.Rows
                        [e.RowIndex].Cells["codProfessor"].Value.ToString());
                }

                mskCpf.Text = dgvCadProf.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                txtNome.Text = dgvCadProf.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                mskTelefone.Text = dgvCadProf.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
                txtEndereco.Text = dgvCadProf.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
                txtCurso.Text = dgvCadProf.Rows[e.RowIndex].Cells["curso"].Value.ToString();
                txtEmail.Text = dgvCadProf.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtSenha.Text = dgvCadProf.Rows[e.RowIndex].Cells["senha"].Value.ToString();



                dgvCadProf.DataSource = professor.RetProfessor();
            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnMostrarProfessor_Click(object sender, EventArgs e)
        {
            dgvCadProf.DataSource = professor.RetProfessor();
        }
    }
}
