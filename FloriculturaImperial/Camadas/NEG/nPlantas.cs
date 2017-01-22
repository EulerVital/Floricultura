using FloriculturaImperial.Camadas.DAO;
using FloriculturaImperial.Camadas.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriculturaImperial.Camadas.NEG
{
    class nPlantas
    {

        public static int insPlantas(ePlantas planta)
        {
            try
            {
                dPlantas db = new dPlantas();
                return db.insPlantas(planta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ePlantas> selPlantas(string nome)
        {
            try
            {
                dPlantas db = new dPlantas();
                return db.selPlantas(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool delPlantas(int? idPlanta, int? idFoto)
        {
            try
            { dPlantas db = new dPlantas();
                return db.delPlanta(idPlanta, idFoto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
