using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace novoEscolaFuturo
{
    class ClassLogin
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();


        public int loginDiretor()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM diretor WHERE email = '{0}' AND senha = '{1}'", Email, Senha));
            bd.Desconectar();
            int linha = (dt.Rows.Count > 0) ? 1 : 0;
            return linha;
        }
        public int loginCoordenador()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM coordenador WHERE email = '{0}' AND senha = '{1}'", Email, Senha));
            bd.Desconectar();
            int linha = (dt.Rows.Count > 0) ? 1 : 0;
            return linha;
        }
        public int loginSecretaria()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM secretaria WHERE email = '{0}' AND senha = '{1}'", Email, Senha));
            bd.Desconectar();
            int linha = (dt.Rows.Count > 0) ? 1 : 0;
            return linha;
        }
        public int loginProfessor()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM professor WHERE email = '{0}' AND senha = '{1}'", Email, Senha));
            bd.Desconectar();
            int linha = (dt.Rows.Count > 0) ? 1 : 0;
            return linha;
        }
    }
}