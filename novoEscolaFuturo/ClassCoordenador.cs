using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace novoEscolaFuturo
{
    class ClassCoordenador
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        int codCoordenadorClicado = 0;


        ClassAcessoBD bd = new ClassAcessoBD();

        //Inserir Funcionário
        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO coordenador (cpf,nome,email,senha) " + "VALUES ('{0}','{1}','{2}','{3}')", Cpf, Nome, Email, Senha));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do coordenador. ");
            }

        }
        //Editar 
        public bool Editar(int codCoordenadorClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE coordenador SET cpf ='{0}', nome ='{1}', email ='{2}', senha = '{3}' WHERE codCoordenador = {4}", Cpf, Nome, Email, Senha, codCoordenadorClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste coordenador" +
                    ". ");
            }
        }

        //Excluir 
        public bool Excluir(int codCoordenadorClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM coordenador WHERE codCoordenador LIKE {0}", codCoordenadorClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do coordeenador. ");
            }
        }

        //Retornar Funcionario
        public DataTable RetCoordenador()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM coordenador"));
            bd.Desconectar();
            return dt;
        }
    }
}