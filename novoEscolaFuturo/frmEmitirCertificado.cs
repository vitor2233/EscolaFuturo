using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novoEscolaFuturo
{
    public partial class frmEmitirCertificado : Form
    {
        ClassAluno aluno = new ClassAluno();
        public frmEmitirCertificado()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmitirCertificado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvEmitirCertificado.DataSource = aluno.EmitirCertificadoNome(txtBusca.Text);
        }

        private void lblEmitirCertificado_Click(object sender, EventArgs e)
        {

        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            dgvEmitirCertificado.DataSource = aluno.EmitirCertificado();
        }
    }
}
