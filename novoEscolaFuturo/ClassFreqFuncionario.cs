using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace novoEscolaFuturo
{
    class ClassFreqFuncionario
    {
        public int Funcionario_codFuncionario { get; set; }
        public string HorarioE { get; set; }
        public string HorarioS { get; set; }
        public string Intervalo { get; set; }
        public string Atestado { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        int codFreqFuncClicado = 0;

        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO freqFuncionario (funcionario_codFuncionario,horarioE,horarioS,intervalo,atestado) VALUES ({0},'{1}','{2}','{3}','{4}')", Funcionario_codFuncionario, HorarioE, HorarioS, Intervalo,Atestado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar a frequência do funcionário. ");
            }
        }

        public bool Editar(int codFreqFuncClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE freqFuncionario SET  funcionario_codFuncionario= {0}, horarioE = '{1}',horarioS = '{2}', intervalo = '{3}', atestado = '{4}' WHERE codFreqF = {5}", Funcionario_codFuncionario, HorarioE, HorarioS, Intervalo, Atestado, codFreqFuncClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar a frequência do funcionário. ");
            }
        }
        public DataTable RetFreqFunc()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM freqFuncionario"));
            bd.Desconectar();
            return dt;
        }
        
        public DataTable RetFreqFuncNome(string busca)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT F.codFreqF, F.horarioE, F.horarioS, P.nome FROM  freqFuncionario AS F INNER JOIN funcionario AS P ON funcionario_codFuncionario = codFuncionario WHERE P.nome LIKE '%{0}%' ", busca));
            bd.Desconectar();

            return dt;
        }
    }
}
