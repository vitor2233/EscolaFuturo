using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace novoEscolaFuturo
{
    class ClassSecretaria
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        int codSecretariaClicado = 0;


        ClassAcessoBD bd = new ClassAcessoBD();

        //Inserir Secretária
        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO secretaria (cpf,nome,email,senha) " + "VALUES ('{0}','{1}','{2}','{3}')", Cpf, Nome, Email, Senha));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados da secretária. ");
            }

        }
        //Editar 
        public bool Editar(int codSecretariaClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE secretaria SET cpf ='{0}', nome ='{1}', email ='{2}', senha = '{3}' WHERE codSecretaria = {4}", Cpf, Nome, Email, Senha, codSecretariaClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados desta secretária" +
                    ". ");
            }
        }

        //Excluir 
        public bool Excluir(int codSecretariaClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM secretaria WHERE codSecretaria LIKE {0}", codSecretariaClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados da secretária. ");
            }
        }

        //Retornar Funcionario
        public DataTable RetSecretaria()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM secretaria"));
            bd.Desconectar();
            return dt;
        }
    }
}