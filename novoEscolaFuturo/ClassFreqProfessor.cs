using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novoEscolaFuturo
{
    class ClassFreqProfessor
    {
        public int Professor_codProfessor { get; set; }
        public string HorarioE { get; set; }
        public string HorarioS { get; set; }
        public string Intervalo { get; set; }
        public string Atestado { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        int codFreqProfClicado = 0;

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO freqProfessor (professor_codProfessor,horarioE,horarioS,intervalo,atestado) VALUES ({0},'{1}','{2}','{3}','{4}')", Professor_codProfessor, HorarioE, HorarioS, Intervalo, Atestado));
                bd.Desconectar();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar a frequência do professor. ");
            }
        }
        public bool Editar(int codFreqProfClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE freqProfessor SET  professor_codProfessor= {0}, horarioE = '{1}',horarioS = '{2}', intervalo = '{3}', atestado = '{4}' WHERE codFreqP = {5}", Professor_codProfessor, HorarioE, HorarioS, Intervalo, Atestado, codFreqProfClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar a frequência do professor. ");
            }
        }

        public DataTable RetFreqProf()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM freqProfessor"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetFreqProfNome(string busca)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT F.codFreqP, F.horarioE, F.horarioS, P.nome FROM  freqProfessor AS F INNER JOIN professor AS P ON professor_codProfessor = codProfessor WHERE P.nome LIKE '%{0}%' ", busca));
            bd.Desconectar();

            return dt;
        }
    }
}
