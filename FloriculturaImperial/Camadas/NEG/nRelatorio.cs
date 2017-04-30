using FloriculturaImperial.Camadas.DAO;
using FloriculturaImperial.Camadas.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriculturaImperial.Camadas.NEG
{
    public class nRelatorio
    {
        public static bool insRelatoriosSalvos(int? id, string listaIds, bool? Excluido, string Descricao)
        {
            try
            {
                dRelatorio db = new dRelatorio();
                return db.insRelatoriosSalvos(id, listaIds, Excluido, Descricao);
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public static List<eRelatorio> selRelatoriosSalvos(int? id, string listaIds, bool? Excluido)
        {
            try
            {
                dRelatorio db = new dRelatorio();
                return db.selRelatoriosSalvos(id, listaIds, Excluido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
