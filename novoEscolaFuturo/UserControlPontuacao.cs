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
    public partial class UserControlPontuacao : UserControl
    {
        ClassPontuacao pontuacao = new ClassPontuacao();
        ClassAluno aluno = new ClassAluno();
        ClassCurso curso = new ClassCurso();

        int codPontuacaoClicada = 0;
        int codAlunoClicado = 0;
        int codCursoClicado = 0;

        public UserControlPontuacao()
        {
            InitializeComponent();
        }

        private void UserControlPontuacao_Load(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            pontuacao.descricao = txtDescDistribuicao.Text;
            pontuacao.pontuacao = int.Parse(txtPontuacaoFinal.Text);
            pontuacao.aluno_codAluno = int.Parse(txtAluno.Text);
            pontuacao.curso_codCurso = int.Parse(txtCurso.Text);

            if (pontuacao.Inserir() == true)
            {
                MessageBox.Show("Pontuação cadastrado com sucesso!");
                dgvPontuacao.DataSource = pontuacao.RetPontuacao();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar a pontuação!");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            pontuacao.descricao = txtDescDistribuicao.Text;
            pontuacao.pontuacao = int.Parse(txtPontuacaoFinal.Text);
            pontuacao.aluno_codAluno = int.Parse(txtAluno.Text);
            pontuacao.curso_codCurso = int.Parse(txtCurso.Text);

            if (pontuacao.Editar(codPontuacaoClicada) == true)
            {
                MessageBox.Show("pontuação foi editada com sucesso!");
                dgvPontuacao.DataSource = pontuacao.RetPontuacao();
            }
            else
            {
                MessageBox.Show("Erro ao editar a pontuação!");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (pontuacao.Excluir(codPontuacaoClicada) == true)
            {
                pontuacao.descricao = txtDescDistribuicao.Text;
                pontuacao.pontuacao = int.Parse(txtPontuacaoFinal.Text);
                pontuacao.aluno_codAluno = int.Parse(txtAluno.Text);
                pontuacao.curso_codCurso = int.Parse(txtCurso.Text);

                MessageBox.Show("A pontuação foi excluído com sucesso!");
                dgvPontuacao.DataSource = pontuacao.RetPontuacao();
            }
        }

        private void DgvPontuacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtDescDistribuicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarAluno_Click(object sender, EventArgs e)
        {
            dgvAluno.DataSource = aluno.RetAlunos();
        }

        private void btnMostrarPontuacao_Click(object sender, EventArgs e)
        {
            dgvPontuacao.DataSource = pontuacao.RetPontuacao();
        }

        private void btnMostrarCurso_Click(object sender, EventArgs e)
        {
            dgvCurso.DataSource = curso.RetCurso();
        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvAluno.Rows[e.RowIndex].Cells["codAluno"].
                       Value.ToString() != "")
                {
                    codAlunoClicado = int.Parse(dgvAluno.Rows
                        [e.RowIndex].Cells["codAluno"].Value.ToString());
                }

                txtAluno.Text = dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString();

                dgvAluno.DataSource = aluno.RetAlunos();
            }
        }

        private void dgvPontuacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvPontuacao.Rows[e.RowIndex].Cells["codPontuacao"].
                       Value.ToString() != "")
                {
                    codPontuacaoClicada = int.Parse(dgvPontuacao.Rows
                        [e.RowIndex].Cells["codPontuacao"].Value.ToString());
                }

                txtDescDistribuicao.Text = dgvPontuacao.Rows[e.RowIndex].Cells["descDistribuicao"].Value.ToString();
                txtPontuacaoFinal.Text = dgvPontuacao.Rows[e.RowIndex].Cells["pontuacaoFinal"].Value.ToString();
                txtCurso.Text = dgvPontuacao.Rows[e.RowIndex].Cells["curso_codCurso"].Value.ToString();
                txtAluno.Text = dgvPontuacao.Rows[e.RowIndex].Cells["aluno_codAluno"].Value.ToString();


                dgvPontuacao.DataSource = pontuacao.RetPontuacao();
            }
        }

        private void dgvCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCurso.Rows[e.RowIndex].Cells["codCurso"].
                       Value.ToString() != "")
                {
                    codCursoClicado = int.Parse(dgvCurso.Rows
                        [e.RowIndex].Cells["codCurso"].Value.ToString());
                }

                txtCurso.Text = dgvCurso.Rows[e.RowIndex].Cells["codCurso"].Value.ToString();

                dgvCurso.DataSource = curso.RetCurso();
            }
        }
    }
}
