using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Loja.DAL;
using Loja.Modelos;

namespace Loja.BLL
{
    public class VendasBLL
    {
        private VendasDAL objDAL;

        public VendasBLL()
        {
            objDAL = new VendasDAL();
        }
        public DataTable ListaDeProdutos
        {
            get
            {
                return objDAL.ListaDeProdutos;
            }
        }
        public DataTable ListaDeClientes
        {
            get
            {
                return objDAL.ListaDeClientes;
            }
        }
        public void Incluir(VendaInformation venda)
        {
            objDAL.Incluir(venda);
        }

    }
}
