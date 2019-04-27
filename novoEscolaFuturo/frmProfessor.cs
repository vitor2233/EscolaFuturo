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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPontuacao_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnPontuacao.Height;
            pnlIndicador.Top = btnPontuacao.Top;
            userControlPontuacao1.BringToFront();
        }

        private void btnFreqAluno_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnFreqAluno.Height;
            pnlIndicador.Top = btnFreqAluno.Top;
            userControlFreqAluno1.BringToFront();
        }

        private void btnPlanoAula_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnPlanoAula.Height;
            pnlIndicador.Top = btnPlanoAula.Top;
            userControlCadPlanoProf1.BringToFront();
        }
    }
}
