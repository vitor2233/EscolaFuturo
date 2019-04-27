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
    public partial class UserControlLogin : UserControl
    {
        ClassLogin lgn = new ClassLogin();

        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void lblEscolaFuturo_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lgn.Email = txtEmail.Text;
            lgn.Senha = txtSenha.Text;

            if(lgn.loginDiretor() == 0)
            {//Se não existir verifica outro login e assim por diante
                if (lgn.loginCoordenador() == 0)
                {
                    if (lgn.loginSecretaria() == 0)
                    {
                        if (lgn.loginProfessor() == 0)
                        {
                            MessageBox.Show("Usuário não existe");
                        }
                        else
                        {
                            frmProfessor frm = new frmProfessor();
                            frm.Show();
                        }
                    }
                    else
                    {
                        frmSecretaria frm = new frmSecretaria();
                        frm.Show();
                    }
                }
                else
                {
                    frmCoordenador frm = new frmCoordenador();
                    frm.Show();
                }
                
            }
            else
            {
                frmDiretor frm = new frmDiretor();
                frm.Show();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '•';
        }
    }
}
