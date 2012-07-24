using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.DAL
{
    class Dados
    {
        public static string StringDeConexao
        {
            get
            {
                return "server=DANIEL-PC\\MSQLSERVER;database=Loja;Trusted_Connection=True";
            }
        }
    }
}
