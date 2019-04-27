using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novoEscolaFuturo
{
    class ClassAluno
    {
        public int Curso_codCurso { get; set; }
        public string Rg { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        int codAlunoClicado = 0;

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO aluno (curso_codCurso,rg,nome,telefone,endereco) VALUES ({0},'{1}','{2}','{3}','{4}')", Curso_codCurso, Rg, Nome, Telefone, Endereco));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do aluno. ");
            }

        }
        //Editar 
        public bool Editar(int codAlunoCliclado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE aluno SET curso_codCurso = {0}, rg = '{1}', nome ='{2}', telefone = '{3}', endereco = '{4}' WHERE codAluno = {5}", Curso_codCurso, Rg, Nome, Telefone, Endereco, codAlunoCliclado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste Aluno" +
                    ". ");
            }
        }

        public bool Excluir(int codAlunoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM aluno WHERE codAluno LIKE {0}", codAlunoClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do Aluno. ");
            }
        }
        public DataTable RetAlunos()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM aluno"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetAlunosNome(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE nome LIKE '%{0}%'", busca));

            bd.Desconectar();

            return dt;
        }

        public DataTable EmitirBoletim()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT A.nome AS nomeAluno , P.pontuacaoFinal, C.nome AS nomeCurso FROM aluno AS A INNER JOIN pontuacao AS p ON A.codAluno = P.aluno_codAluno INNER JOIN curso AS C ON A.curso_codCurso = C.codCurso"));
            bd.Desconectar();

            return dt;

        }

        public DataTable RetBoletimNome(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT A.nome AS Aluno, P.pontuacaoFinal AS Pontuação, C.nome AS Curso FROM aluno AS A INNER JOIN pontuacao AS p ON A.codAluno = P.aluno_codAluno INNER JOIN curso AS C ON A.curso_codCurso = C.codCurso WHERE A.nome LIKE '%{0}%'", busca));

            bd.Desconectar();

            return dt;
        }

        public DataTable EmitirCertificado()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT A.nome AS Aluno, C.nome AS Curso FROM aluno AS A INNER JOIN curso AS C ON A.curso_codCurso = C.codCurso"));
            bd.Desconectar();

            return dt;

        }

        public DataTable EmitirCertificadoNome(string busca)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT A.nome AS Aluno, C.nome AS Curso FROM aluno AS A INNER JOIN curso AS C ON A.curso_codCurso = C.codCurso WHERE A.nome LIKE '%{0}%'", busca));
            bd.Desconectar();

            return dt;

        }
    }
}
