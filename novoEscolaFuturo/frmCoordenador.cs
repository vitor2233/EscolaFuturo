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
    public partial class frmCoordenador : Form
    {
        public frmCoordenador()
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

        private void userControlCadCurso1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnCadFuncionario.Height;
            pnlIndicador.Top = btnCadFuncionario.Top;
            userControlCadFuncionario1.BringToFront();
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnCadastrarCurso.Height;
            pnlIndicador.Top = btnCadastrarCurso.Top;
            userControlCadCurso1.BringToFront();
        }

        private void btEmitirRelatorio_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btEmitirRelatorio.Height;
            pnlIndicador.Top = btEmitirRelatorio.Top;
            userControlFreqProf1.BringToFront();
        }

        private void userControlBemVindo1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadProfesor_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnCadProfesor.Height;
            pnlIndicador.Top = btnCadProfesor.Top;
            userControlCadProfessor1.BringToFront();
        }
    }
}
