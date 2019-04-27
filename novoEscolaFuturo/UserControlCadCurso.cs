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
    public partial class UserControlCadCurso : UserControl
    {
        ClassCurso curso = new ClassCurso();

        int codCursoClicado = 0;
        public UserControlCadCurso()
        {
            InitializeComponent();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {


            curso.Nome = txtNome.Text;
            curso.Conteudo = txtConteudoCurso.Text;
            curso.PlanoCurso = txtPlano.Text;

            if (curso.Inserir() == true)
            {
                MessageBox.Show("Curso cadastrado com sucesso!");
                dgvCadCurso.DataSource = curso.RetCurso();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o curso!");
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            curso.Nome = txtNome.Text;
            curso.Conteudo = txtConteudoCurso.Text;
            curso.PlanoCurso = txtPlano.Text;

            if (curso.Editar(codCursoClicado) == true)
            {
                MessageBox.Show("Curso editado com sucesso!");
                dgvCadCurso.DataSource = curso.RetCurso();
            }
            else
            {
                MessageBox.Show("Erro ao editar o curso!");
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
       {
            if (curso.Excluir(codCursoClicado) == true)
            {
                curso.Nome = txtNome.Text;
                curso.Conteudo = txtConteudoCurso.Text;
                curso.PlanoCurso = txtPlano.Text;

                MessageBox.Show("O curso foi excluído com sucesso!");
                dgvCadCurso.DataSource = curso.RetCurso();
            }
       }

        private void DgvCadCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvCadCurso.DataSource = curso.RetCursosNome(txtBuscarCurso.Text);

        }

        private void dgvCadCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCadCurso.Rows[e.RowIndex].Cells["codCurso"].
                       Value.ToString() != "")
                {
                    codCursoClicado = int.Parse(dgvCadCurso.Rows
                        [e.RowIndex].Cells["codCurso"].Value.ToString());
                }


                txtNome.Text = dgvCadCurso.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtConteudoCurso.Text = dgvCadCurso.Rows[e.RowIndex].Cells["conteudoCurso"].Value.ToString();
                txtPlano.Text = dgvCadCurso.Rows[e.RowIndex].Cells["planoCurso"].Value.ToString();


                dgvCadCurso.DataSource = curso.RetCurso();
            }
        }

        private void btnMostrarCurso_Click(object sender, EventArgs e)
        {
            dgvCadCurso.DataSource = curso.RetCurso();
        }
    }
}
