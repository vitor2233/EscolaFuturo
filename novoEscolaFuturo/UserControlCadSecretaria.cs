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
    public partial class UserControlCadSecretaria : UserControl
    {
        ClassSecretaria sec = new ClassSecretaria();

        int codSecretariaClicada = 0;

        public UserControlCadSecretaria()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            sec.Nome = txtNome.Text;
            sec.Cpf = mskCpf.Text;
            sec.Email = txtEmail.Text;
            sec.Senha = txtSenha.Text;

            if(sec.Inserir() == true)
            {
                MessageBox.Show("Sercretária cadastrada com sucesso.");
                dgvCadSecretaria.DataSource = sec.RetSecretaria();
            }else
            {
                MessageBox.Show("Erro ao cadastrar secretária");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            sec.Nome = txtNome.Text;
            sec.Cpf = mskCpf.Text;
            sec.Email = txtEmail.Text;
            sec.Senha = txtSenha.Text;

            if (sec.Editar(codSecretariaClicada) == true)
            {
                MessageBox.Show("Sercretária editada com sucesso.");
                dgvCadSecretaria.DataSource = sec.RetSecretaria();
            }
            else
            {
                MessageBox.Show("Erro ao editar secretária");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(sec.Excluir(codSecretariaClicada) == true)
            {
                sec.Nome = txtNome.Text;
                sec.Cpf = mskCpf.Text;
                sec.Email = txtEmail.Text;
                sec.Senha = txtSenha.Text;

                MessageBox.Show("Secretária excluída com sucesso.");
                dgvCadSecretaria.DataSource = sec.RetSecretaria();
            }
        }

        private void btnMostrarSecretaria_Click(object sender, EventArgs e)
        {
            dgvCadSecretaria.DataSource = sec.RetSecretaria();
        }

        private void dgvCadSecretaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dgvCadSecretaria.Rows[e.RowIndex].Cells["codSecretaria"].
                       Value.ToString() != "")
                {
                    codSecretariaClicada = int.Parse(dgvCadSecretaria.Rows
                        [e.RowIndex].Cells["codSecretaria"].Value.ToString());
                }
                mskCpf.Text = dgvCadSecretaria.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                txtNome.Text = dgvCadSecretaria.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtEmail.Text = dgvCadSecretaria.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtSenha.Text = dgvCadSecretaria.Rows[e.RowIndex].Cells["senha"].Value.ToString();


                dgvCadSecretaria.DataSource = sec.RetSecretaria();
            }
        }
    }
}
