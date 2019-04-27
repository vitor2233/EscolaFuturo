using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novoEscolaFuturo
{
    class ClassFreqAluno
    {
        public int Aluno_codAluno { get; set; }
        public string  Presente { get; set; }

        int codFreqAlunoClicado = 0;
        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO freqAluno (aluno_codAluno,presente) VALUES ({0},'{1}')", Aluno_codAluno, Presente));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar a frequência do aluno. ");
            }
        }

        public bool Editar(int codFreqAlunoClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE freqAluno SET presente = '{0}' WHERE codFreqA = {1}", Presente, codFreqAlunoClicado));
                bd.Desconectar();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar a frequência do aluno. ");
            }
        }
        
       public DataTable RetFreqAluno()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM freqAluno"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetAlunoCod(string busca)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT F.codFreqA, A.nome, F.dia, F.presente FROM freqAluno AS F INNER JOIN aluno AS A ON A.codAluno = F.aluno_codAluno WHERE A.nome LIKE '%{0}%'; ", busca));
            bd.Desconectar();

            return dt;
        }

    }
}
