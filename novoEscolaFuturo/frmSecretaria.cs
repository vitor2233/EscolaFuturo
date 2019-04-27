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
    public partial class frmSecretaria : Form
    {
        public frmSecretaria()
        {
            InitializeComponent();
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnCadAluno.Height;
            pnlIndicador.Top = btnCadAluno.Top;
            userControlCadAluno1.BringToFront();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
