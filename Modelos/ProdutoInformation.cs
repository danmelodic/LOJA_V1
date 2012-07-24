using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Modelos
{
    public class ProdutoInformation
    {
        public int codigo       { get; set; }
        public string nome      { get; set; }
        public decimal preco    { get; set; }
        public int estoque      { get; set; }
    }
}
