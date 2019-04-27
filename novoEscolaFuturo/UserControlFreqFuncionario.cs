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
    public partial class UserControlFreqFuncionario : UserControl
    {
   
        ClassFreqFuncionario freqFunc = new ClassFreqFuncionario();
        ClassFuncionario funcionario = new ClassFuncionario();

          int codFreqFuncClicado, codFuncionarioClicado = 0;

        public UserControlFreqFuncionario()
        {
            InitializeComponent();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            freqFunc.Atestado = txtAtestado.Text;
            freqFunc.HorarioE = mskHoraE.Text;
            freqFunc.HorarioS = mskHoraS.Text;
            freqFunc.Intervalo = txtIntervalo.Text;
            freqFunc.Funcionario_codFuncionario = int.Parse(txtNome.Text);

            if (freqFunc.Inserir() == true)
            {
                MessageBox.Show("Frequência de funcionário cadastrada com sucesso!");
                dgvFreqFuncionario.DataSource = freqFunc.RetFreqFunc();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            freqFunc.Atestado = txtAtestado.Text;
            freqFunc.HorarioE = mskHoraE.Text;
            freqFunc.HorarioS = mskHoraS.Text;
            freqFunc.Intervalo = txtIntervalo.Text;
            freqFunc.Funcionario_codFuncionario = int.Parse(txtNome.Text);

            if (freqFunc.Editar(codFreqFuncClicado) == true)
            {
                MessageBox.Show("Frequência do funcionário cadastrada com sucesso!");
                dgvFreqFuncionario.DataSource = freqFunc.RetFreqFunc();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
           dgvFreqFuncionario.DataSource = freqFunc.RetFreqFuncNome(txtBusca.Text);
        }

        private void dgvMostrarFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarFunc.Rows[e.RowIndex].Cells["codFuncionario"].
                     Value.ToString() != "")
            {
                codFuncionarioClicado = int.Parse(dgvMostrarFunc.Rows
                    [e.RowIndex].Cells["codFuncionario"].Value.ToString());
            }

            txtNome.Text = dgvMostrarFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString();
        }

        private void btnMostrarFuncionario_Click(object sender, EventArgs e)
        {
            dgvMostrarFunc.DataSource = funcionario.RetFuncionarios();
        }

        private void btnFreqFunc_Click(object sender, EventArgs e)
        {
            dgvFreqFuncionario.DataSource = freqFunc.RetFreqFunc();
        }

        private void dgvFreqFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFreqFuncionario.Rows[e.RowIndex].Cells["codFreqF"].
                     Value.ToString() != "")
            {
                codFreqFuncClicado = int.Parse(dgvFreqFuncionario.Rows
                    [e.RowIndex].Cells["codFreqF"].Value.ToString());
            }

            txtNome.Text = dgvFreqFuncionario.Rows[e.RowIndex].Cells["funcionario_codFuncionario"].Value.ToString();
            txtAtestado.Text = dgvFreqFuncionario.Rows[e.RowIndex].Cells["atestado"].Value.ToString();
            txtIntervalo.Text = dgvFreqFuncionario.Rows[e.RowIndex].Cells["intervalo"].Value.ToString();
            mskHoraE.Text = dgvFreqFuncionario.Rows[e.RowIndex].Cells["horarioE"].Value.ToString();
            mskHoraS.Text = dgvFreqFuncionario.Rows[e.RowIndex].Cells["horarioS"].Value.ToString();


        }
    }
}
