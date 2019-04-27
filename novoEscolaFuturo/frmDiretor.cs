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
    public partial class frmDiretor : Form
    {
        public frmDiretor()
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

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnCadastrarCurso.Height;
            pnlIndicador.Top = btnCadastrarCurso.Top;
            userControlCadCurso1.BringToFront();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnCadFuncionario.Height;
            pnlIndicador.Top = btnCadFuncionario.Top;
            userControlCadFuncionario1.BringToFront();
        }

        private void btEmitirRelatorio_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btEmitirRelatorio.Height;
            pnlIndicador.Top = btEmitirRelatorio.Top;
            userControlFreqFuncionario1.BringToFront();

        }

        private void btnCadCoor_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnCadCoor.Height;
            pnlIndicador.Top = btnCadCoor.Top;
            userControlCadCoordenador1.BringToFront();
        }

        private void btnCadSecretaria_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnCadSecretaria.Height;
            pnlIndicador.Top = btnCadSecretaria.Top;
            userControlCadSecretaria1.BringToFront();

        }

        private void frmDiretor_Load(object sender, EventArgs e)
        {

        }
    }
}
