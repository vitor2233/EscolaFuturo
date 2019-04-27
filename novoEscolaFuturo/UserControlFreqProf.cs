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
    public partial class UserControlFreqProf : UserControl
    {
        ClassFreqProfessor freqProf = new ClassFreqProfessor();
        ClassProfessor professor = new ClassProfessor();

        int codFreqProfClicado, codProfessorClicado = 0;

        public UserControlFreqProf()
        {
            InitializeComponent();
        }

        private void btnFreqProf_Click(object sender, EventArgs e)
        {
            dgvFreqProfessor.DataSource = freqProf.RetFreqProf();
        }

        private void btnMostrarProfessor_Click(object sender, EventArgs e)
        {
            dgvProfessor.DataSource = professor.RetProfessor();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            freqProf.Atestado = txtAtestado.Text;
            freqProf.HorarioE = mskHoraE.Text;
            freqProf.HorarioS = mskHoraS.Text;
            freqProf.Intervalo = txtIntervalo.Text;
            freqProf.Professor_codProfessor = int.Parse(txtNome.Text);

            if(freqProf.Inserir() == true)
            {
                MessageBox.Show("Frequência de professor cadastrada com sucesso!");
                dgvFreqProfessor.DataSource = freqProf.RetFreqProf();
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            freqProf.Atestado = txtAtestado.Text;
            freqProf.HorarioE = mskHoraE.Text;
            freqProf.HorarioS = mskHoraS.Text;
            freqProf.Intervalo = txtIntervalo.Text;
            freqProf.Professor_codProfessor = int.Parse(txtNome.Text);

            if (freqProf.Editar(codFreqProfClicado) == true)
            {
                MessageBox.Show("Frequência de professor cadastrada com sucesso!");
                dgvFreqProfessor.DataSource = freqProf.RetFreqProf();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            }

        private void dgvFreqProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFreqProfessor.Rows[e.RowIndex].Cells["codFreqP"].
                     Value.ToString() != "")
            {
                codFreqProfClicado = int.Parse(dgvFreqProfessor.Rows
                    [e.RowIndex].Cells["codFreqP"].Value.ToString());
            }

            txtNome.Text = dgvFreqProfessor.Rows[e.RowIndex].Cells["codFreqP"].Value.ToString();
            txtAtestado.Text = dgvFreqProfessor.Rows[e.RowIndex].Cells["atestado"].Value.ToString();
            txtIntervalo.Text = dgvFreqProfessor.Rows[e.RowIndex].Cells["intervalo"].Value.ToString();
            mskHoraE.Text = dgvFreqProfessor.Rows[e.RowIndex].Cells["horarioE"].Value.ToString();
            mskHoraS.Text = dgvFreqProfessor.Rows[e.RowIndex].Cells["horarioS"].Value.ToString();


      
        }

        private void UserControlFreqProf_Load(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvFreqProfessor.DataSource = freqProf.RetFreqProfNome(txtBusca.Text);

        }

        private void dgvProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfessor.Rows[e.RowIndex].Cells["codProfessor"].
                     Value.ToString() != "")
            {
                codProfessorClicado = int.Parse(dgvProfessor.Rows
                    [e.RowIndex].Cells["codProfessor"].Value.ToString());
            }

            txtNome.Text = dgvProfessor.Rows[e.RowIndex].Cells["codProfessor"].Value.ToString();
          
        }
    }
    
}
