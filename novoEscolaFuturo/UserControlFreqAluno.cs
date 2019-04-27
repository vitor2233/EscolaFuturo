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
    public partial class UserControlFreqAluno : UserControl
    {
        ClassFreqAluno FreqA = new ClassFreqAluno();
        ClassAcessoBD bd = new ClassAcessoBD();
        ClassAluno aluno = new ClassAluno();

        int codAlunoClicado = 0;
        int codFreqAlunoClicado = 0;

        public UserControlFreqAluno()
        {
            InitializeComponent();
        }

        private void dtDia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FreqA.Aluno_codAluno = int.Parse(txtNome.Text);                    
            FreqA.Presente = txtPresente.Text;

            if(FreqA.Inserir() == true)
            {
                MessageBox.Show("Frequência adicionada com sucesso!");
                dgvFreqAluno.DataSource = FreqA.RetFreqAluno();
            }
        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAluno.Rows[e.RowIndex].Cells["codAluno"].
                       Value.ToString() != "")
            {
                codAlunoClicado = int.Parse(dgvAluno.Rows
                    [e.RowIndex].Cells["codAluno"].Value.ToString());
            }

            txtNome.Text = dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString();
        }

        private void btnMostrarAluno_Click(object sender, EventArgs e)
        {
            dgvAluno.DataSource = aluno.RetAlunos();
        }

        private void btnMostrarFreqAluno_Click(object sender, EventArgs e)
        {
            dgvFreqAluno.DataSource = FreqA.RetFreqAluno();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FreqA.Aluno_codAluno = int.Parse(txtNome.Text);
            FreqA.Presente = txtPresente.Text;

            

            if(FreqA.Editar(codFreqAlunoClicado) == true)
            {
                MessageBox.Show("Frequência do aluno editada com sucesso!");
                dgvFreqAluno.DataSource = FreqA.RetFreqAluno();
            }

        }

        private void dgvFreqAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFreqAluno.Rows[e.RowIndex].Cells["codFreqA"].
                       Value.ToString() != "")
            {
                codFreqAlunoClicado = int.Parse(dgvFreqAluno.Rows
                    [e.RowIndex].Cells["codFreqA"].Value.ToString());
            }

            txtNome.Text = dgvFreqAluno.Rows[e.RowIndex].Cells["aluno_codAluno"].Value.ToString();
            txtPresente.Text = dgvFreqAluno.Rows[e.RowIndex].Cells["presente"].Value.ToString();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvFreqAluno.DataSource = FreqA.RetAlunoCod(txtBusca.Text);
        }
    }
}
