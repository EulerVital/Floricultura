using FloriculturaImperial.Camadas.DAO;
using FloriculturaImperial.Camadas.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriculturaImperial.Camadas.NEG
{
    class nFotos
    {
        public static bool insFotos(eFotos foto)
        {
            try
            {
                dFotos db = new dFotos();
                return db.insFotos(foto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<eFotos> selFotos(int? IdPlanta)
        {
            try
            {
                dFotos db = new dFotos();
                return db.selFotos(IdPlanta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
