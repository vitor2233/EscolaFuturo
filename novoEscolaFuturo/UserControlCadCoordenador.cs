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
    public partial class UserControlCadCoordenador : UserControl
    {
        ClassCoordenador cord = new ClassCoordenador();

        int codCoordenadorClicado = 0;

        public UserControlCadCoordenador()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cord.Nome = txtNome.Text;
            cord.Cpf = mskCpf.Text;
            cord.Email = txtEmail.Text;
            cord.Senha = txtSenha.Text;

            if(cord.Inserir() == true)
            {
                MessageBox.Show("Coordenador cadastrado com sucesso");
                dgvCadCoor.DataSource = cord.RetCoordenador();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar coordenador");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cord.Nome = txtNome.Text;
            cord.Cpf = mskCpf.Text;
            cord.Email = txtEmail.Text;
            cord.Senha = txtSenha.Text;

            if (cord.Editar(codCoordenadorClicado) == true)
            {
                MessageBox.Show("Coordenador editado com sucesso");
                dgvCadCoor.DataSource = cord.RetCoordenador();
            }
            else
            {
                MessageBox.Show("Erro ao editar coordenador");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(cord.Excluir(codCoordenadorClicado) == true)
            {
                cord.Nome = txtNome.Text;
                cord.Cpf = mskCpf.Text;
                cord.Email = txtEmail.Text;
                cord.Senha = txtSenha.Text;

                MessageBox.Show("Coordenador excluido com sucesso");
                dgvCadCoor.DataSource = cord.RetCoordenador();
            }
        }

        private void btnMostrarCoordenador_Click(object sender, EventArgs e)
        {
            dgvCadCoor.DataSource = cord.RetCoordenador();
        }

        private void dgvCadCoor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCadCoor.Rows[e.RowIndex].Cells["codCoordenador"].
                       Value.ToString() != "")
                {
                    codCoordenadorClicado = int.Parse(dgvCadCoor.Rows
                        [e.RowIndex].Cells["codCoordenador"].Value.ToString());
                }
                mskCpf.Text = dgvCadCoor.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                txtNome.Text = dgvCadCoor.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtEmail.Text = dgvCadCoor.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtSenha.Text = dgvCadCoor.Rows[e.RowIndex].Cells["senha"].Value.ToString();


                dgvCadCoor.DataSource = cord.RetCoordenador();
            }
        }
    }
}
