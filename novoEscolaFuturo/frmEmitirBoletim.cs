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
    public partial class frmEmitirBoletim : Form
    {
        ClassAluno aluno = new ClassAluno();
        public frmEmitirBoletim()
        {
            InitializeComponent();
        }

        private void frmEmitirBoletim_Load(object sender, EventArgs e)
        {

        }

        private void lblEmitirBoletim_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvEmitirBoletim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            dgvEmitirBoletim.DataSource = aluno.EmitirBoletim();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
           dgvEmitirBoletim.DataSource = aluno.RetBoletimNome(txtBusca.Text);
        }
    }
}
