using FloriculturaImperial.Camadas.DAO;
using FloriculturaImperial.Camadas.ENT;
using System;
using System.Collections.Generic;

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

        public static List<eVendas> selRelatorioVendas(eVendas venda)
        {
            try
            {
                dVendas db = new dVendas();
                return db.selRelatorioVendas(venda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<eVendas> selProdutosVendidos(int? id, string produto)
        {
            try
            {
                dVendas db = new dVendas();
                return db.selProdutosVendidos(id, produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
