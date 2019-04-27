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
    public partial class UserControlCadPlanoProf : UserControl
    {
        ClassCurso curso = new ClassCurso();
        int codCursoClicado = 0;

        public UserControlCadPlanoProf()
        {
            InitializeComponent();
        }

        private void lblCadastrarCurso_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarCurso_Click(object sender, EventArgs e)
        {
            dgvCadCurso.DataSource = curso.RetCurso();
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


                txtCurso.Text = dgvCadCurso.Rows[e.RowIndex].Cells["codCurso"].Value.ToString();
                txtPlano.Text = dgvCadCurso.Rows[e.RowIndex].Cells["planoCurso"].Value.ToString();
                dgvCadCurso.DataSource = curso.RetCurso();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            curso.PlanoCurso = txtPlano.Text;

            if(curso.EditarPlanoCurso(codCursoClicado) == true)
            {
                MessageBox.Show("Plano de curso inserido com sucesso.");
                dgvCadCurso.DataSource = curso.RetCurso();
            }
        }
    }
}
