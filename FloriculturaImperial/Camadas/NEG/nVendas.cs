using FloriculturaImperial.Camadas.DAO;
using FloriculturaImperial.Camadas.ENT;
using System;

namespace FloriculturaImperial.Camadas.NEG
{
    public class nVendas
    {
        public static bool insVendaProduto(eVendas vendas)
        {
            try
            {
                dVendas db = new dVendas();
                return db.insVendaProduto(vendas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool insVendaTotal(eVendas vendas)
        {
            try
            {
                dVendas db = new dVendas();
                return db.insVendaTotal(vendas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
