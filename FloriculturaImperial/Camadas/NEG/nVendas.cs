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

        public static List<eVendas> selVendas(eVendas venda)
        {
            try
            {
                dVendas db = new dVendas();
                return db.selVendas(venda);
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

        public static List<eVendas> selRelatorioVendas(DateTime? dataAte, DateTime? dataDe, string nomeProd, int? qtdMaior, decimal? preco, string ids)
        {
            try
            {
                dVendas db = new dVendas();
                return db.selRelatorioVendas(dataAte,dataDe,nomeProd,qtdMaior,preco, ids);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
