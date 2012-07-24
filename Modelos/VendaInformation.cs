using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Modelos
{
    public class VendaInformation
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        private bool _faturado;
        public bool Faturado
        {
            get { return _faturado; }
            set { _faturado = value; }
        }


        private int _codigoCliente;
        public int CodigoCliente
        {
            get { return _codigoCliente; }
            set { _codigoCliente = value; }
        }

        private int _codigoProduto;
        public int CodigoProduto
        {
            get { return _codigoProduto; }
            set { _codigoProduto = value; }
        }


        private string _nomeCliente;
        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }
    }
}
