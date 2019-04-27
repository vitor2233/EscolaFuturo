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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnPaginaInicial.Height;
            pnlIndicador.Top = btnPaginaInicial.Top;
            userControlBemVindo1.BringToFront();
        }

        private void btnDiretor_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnDiretor.Height;
            pnlIndicador.Top = btnDiretor.Top;
            userControlLogin1.BringToFront();
        }

        private void btnCoordenador_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnCoordenador.Height;
            pnlIndicador.Top = btnCoordenador.Top;
            userControlLogin1.BringToFront();
        }

        private void btnScretaria_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnScretaria.Height;
            pnlIndicador.Top = btnScretaria.Top;
            userControlLogin1.BringToFront();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            pnlIndicador.Height = btnProfessor.Height;
            pnlIndicador.Top = btnProfessor.Top;
            userControlLogin1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
