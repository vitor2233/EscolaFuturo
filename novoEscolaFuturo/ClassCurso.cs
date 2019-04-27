using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novoEscolaFuturo
{
    class ClassCurso
    {
       
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public string PlanoCurso { get; set; }

        int codCursoClicado = 0;

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO curso (nome, conteudoCurso) VALUES ('{0}','{1}')", Nome, Conteudo));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar o curso. ");
            }

        }
        //Editar 
        public bool Editar(int codCursoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE curso SET nome = '{0}', conteudoCurso = '{1}', planoCurso = '{2}' WHERE codCurso = {3}", Nome, Conteudo, PlanoCurso, codCursoClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados do curso" +
                    ". ");
            }
        }

        public bool EditarPlanoCurso(int codCursoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE curso SET planoCurso = '{0}' WHERE codCurso = {1}",PlanoCurso, codCursoClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados do curso" +
                    ". ");
            }
        }

        public bool Excluir(int codCursoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM curso WHERE codCurso LIKE {0}", codCursoClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do curso. ");
            }
        }
        public DataTable RetCurso()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM curso"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetCursosNome(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM curso WHERE nome LIKE '%{0}%'", busca));

            bd.Desconectar();

            return dt;
        }

    }
}
