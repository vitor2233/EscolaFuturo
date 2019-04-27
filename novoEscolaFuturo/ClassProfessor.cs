using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novoEscolaFuturo
{
    class ClassProfessor
    {

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Curso { get; set; }

        int codProfessorClicado = 0;

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO professor (cpf,nome,telefone,endereco,curso) VALUES ('{0}','{1}','{2}','{3}','{4}')", Cpf, Nome, Telefone, Endereco, Curso));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do Professor. ");
            }

        }
        public bool Editar(int codProfessorClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE professor SET  cpf='{0}', nome='{1}', telefone='{2}', endereco='{3}', curso='{4}' WHERE codProfessor = {5}", Cpf, Nome, Telefone, Endereco, Curso, codProfessorClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste professor" +
                    ". ");
            }
        }
        public bool Excluir(int codProfessorClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM professor WHERE codProfessor LIKE {0}", codProfessorClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do Professor. ");
            }
        }
        public DataTable RetProfessor()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM professor"));
            bd.Desconectar();
            return dt;
        }



    }
}
