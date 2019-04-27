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
    public partial class UserControlCadAluno : UserControl
    {
        ClassAluno aluno = new ClassAluno();
        ClassCurso curso = new ClassCurso();
        int codAlunoClicado = 0;
        int codCursoClicado = 0;

        public UserControlCadAluno()
        {
            InitializeComponent();
        }

        private void btnMostrarCurso_Click(object sender, EventArgs e)
        {
            dgvCurso.DataSource = curso.RetCurso();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtNome.Text;
            aluno.Rg = mskRg.Text;
            aluno.Telefone = mskTelefone.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.Curso_codCurso = int.Parse(txtCurso.Text);

            if (aluno.Inserir() == true)
            {
                MessageBox.Show("Aluno cadastrado com sucesso!");
                dgvCadAluno.DataSource = aluno.RetAlunos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastraro aluno!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtNome.Text;
            aluno.Rg = mskRg.Text;
            aluno.Telefone = mskTelefone.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.Curso_codCurso = int.Parse(txtCurso.Text);

            if (aluno.Editar(codAlunoClicado) == true)
            {
                MessageBox.Show("Aluno foi editado com sucesso!");
                dgvCadAluno.DataSource = aluno.RetAlunos();
            }
            else
            {
                MessageBox.Show("Erro ao editar o aluno!");
            }
        }

        private void dgvCadAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCadAluno.Rows[e.RowIndex].Cells["codAluno"].
                       Value.ToString() != "")
                {
                    codAlunoClicado = int.Parse(dgvCadAluno.Rows
                        [e.RowIndex].Cells["codAluno"].Value.ToString());
                }

                txtCurso.Text = dgvCadAluno.Rows[e.RowIndex].Cells["curso_codCurso"].Value.ToString();
                txtEndereco.Text = dgvCadAluno.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
                txtNome.Text = dgvCadAluno.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                mskRg.Text = dgvCadAluno.Rows[e.RowIndex].Cells["rg"].Value.ToString();
                mskTelefone.Text = dgvCadAluno.Rows[e.RowIndex].Cells["telefone"].Value.ToString();


                dgvCadAluno.DataSource = aluno.RetAlunos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtNome.Text;
            aluno.Rg = mskRg.Text;
            aluno.Telefone = mskTelefone.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.Curso_codCurso = int.Parse(txtCurso.Text);

            if (aluno.Excluir(codAlunoClicado) == true)
            {
                MessageBox.Show("O aluno foi excluído com sucesso!");
                dgvCadAluno.DataSource = aluno.RetAlunos();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvCadAluno.DataSource = aluno.RetAlunosNome(txtBuscarAluno.Text);
        }

        private void TxtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlCadAluno_Load(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurso.Rows[e.RowIndex].Cells["codCurso"].
                       Value.ToString() != "")
            {
                codCursoClicado = int.Parse(dgvCurso.Rows
                    [e.RowIndex].Cells["codCurso"].Value.ToString());
            }

            txtCurso.Text = dgvCurso.Rows[e.RowIndex].Cells["codCurso"].Value.ToString();

        }

        private void btnMostrarAluno_Click(object sender, EventArgs e)
        {
            dgvCadAluno.DataSource = aluno.RetAlunos();
        }

        private void txtBuscarCurso_TextChanged(object sender, EventArgs e)
        {
            dgvCurso.DataSource = curso.RetCursosNome(txtBuscarCurso.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmitirBoletim boletim = new frmEmitirBoletim();
            boletim.Show();

        }

        private void btnCertificadoDeConclusao_Click(object sender, EventArgs e)
        {
            frmEmitirCertificado certificado = new frmEmitirCertificado();
            certificado.Show();
        }
    }
}
