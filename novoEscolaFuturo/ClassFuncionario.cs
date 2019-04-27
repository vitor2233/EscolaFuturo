using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace novoEscolaFuturo
{
    class ClassFuncionario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
      
        public int Tipo { get; set; }

        int codFuncionarioClicado = 0;


        ClassAcessoBD bd = new ClassAcessoBD();

        //Inserir Funcionário
        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO funcionario (cpf,nome,telefone,endereco,tipo) " + "VALUES ('{0}','{1}','{2}','{3}',{4})", Cpf, Nome, Telefone, Endereco, Tipo));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do funcionário. ");
            }

        }
        //Editar 
        public bool Editar(int codFuncionarioClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE funcionario SET cpf ='{0}', nome ='{1}', telefone ='{2}', endereco = '{3}', tipo ={4} WHERE codFuncionario = {5}", Cpf, Nome, Telefone, Endereco, Tipo, codFuncionarioClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste funcionário" +
                    ". ");
            }
        }

        //Excluir 
        public bool Excluir(int codFuncionarioClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM funcionario WHERE codFuncionario LIKE {0}", codFuncionarioClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do funcionário. ");
            }
        }

        //Retornar Funcionario
        public DataTable RetFuncionarios()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM funcionario"));
            bd.Desconectar();
            return dt;
        }
    }
}